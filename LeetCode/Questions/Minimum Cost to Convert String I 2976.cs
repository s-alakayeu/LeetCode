namespace LeetCode.Questions;

public static class Minimum_Cost_to_Convert_String_I_2976
{
    public static long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
    {
        var adjacency = new List<Tuple<int, int>>[26];
        
        for (var i = 0; i < 26; i++)
        {
            adjacency[i] = [];
        }

        for (var i = 0; i < original.Length; i++)
        {
            adjacency[original[i] - 'a'].Add(new Tuple<int, int>(changed[i] - 'a', cost[i]));
        }
        
        var minConversionCosts = new long[26][];

        for (var i = 0; i < 26; i++)
        {
            minConversionCosts[i] = Dijkstra(i, adjacency);
        }
        
        var totalCost = 0l;
        
        for (var i = 0; i < source.Length; i++)
        {
            if (source[i] == target[i])
            {
                continue;
            }
            
            var conversionCost = minConversionCosts[source[i] - 'a'][target[i] - 'a'];
            if (conversionCost == -1) 
            {
                return -1;
            }
                
            totalCost += conversionCost;
        }
        return totalCost;
    }

    private static long[] Dijkstra(int index, IReadOnlyList<List<Tuple<int, int>>> adjacency)
    {
        var priorityQueue = new PriorityQueue<Tuple<int, int>, int>();
        
        priorityQueue.Enqueue(new Tuple<int, int>(index, 0), 0);

        var minCosts = new long[26];
        
        Array.Fill(minCosts, -1);

        while (priorityQueue.Count > 0)
        {
            var (currentChar, currentCost) = priorityQueue.Dequeue();

            if (minCosts[currentChar] != -1 && minCosts[currentChar] < currentCost)
            {
                continue;
            }

            for (var i = 0; i < adjacency[currentChar].Count; i++)
            {
                var (targetChar, conversionCost) = adjacency[currentChar][i];
                var targetCost = currentCost + conversionCost;

                if (minCosts[targetChar] != -1 && targetCost >= minCosts[targetChar])
                {
                    continue;
                }
                
                minCosts[targetChar] = targetCost;
                priorityQueue.Enqueue(new Tuple<int, int>(targetChar, targetCost), targetCost);
            }
        }

        return minCosts;
    }
}