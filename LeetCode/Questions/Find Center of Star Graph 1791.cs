namespace LeetCode.Questions;

public static class Find_Center_of_Star_Graph_1791
{
    public static int FindCenter(int[][] edges)
    {
        var hashSet = new HashSet<int>();
        
        foreach (var edge in edges)
        {
            if (!hashSet.Add(edge[0]))
            {
                return edge[0];
            }

            if (!hashSet.Add(edge[1]))
            {
                return edge[1];
            }
        }

        return -1;
    }
}