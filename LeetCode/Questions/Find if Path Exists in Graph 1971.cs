namespace LeetCode.Questions;

public static class Find_if_Path_Exists_in_Graph_1971
{
    public static bool ValidPath(int n, int[][] edges, int source, int destination) {
        var hash = new Dictionary<int, List<int>>();

        foreach (var edge in edges)
        {
            if (!hash.ContainsKey(edge[0]))
            {
                hash[edge[0]] = [];
            }

            if (!hash.ContainsKey(edge[1]))
            {
                hash[edge[1]] = [];
            }
            
            hash[edge[0]].Add(edge[1]);
            hash[edge[1]].Add(edge[0]);
        }

        var visit = new HashSet<int>();
        var q = new Queue<int>();
        q.Enqueue(source);

        while (q.Count > 0)
        {
            var cur = q.Dequeue();
            
            if (cur == destination)
            {
                return true;
            }

            foreach (var node in hash[cur])
            {
                if (!visit.Contains(node))
                {
                    q.Enqueue(node);
                    visit.Add(node);
                }
            }
        }
        return false;
    }
}