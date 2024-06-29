namespace LeetCode.Questions;

public static class All_Ancestors_of_a_Node_in_a_Directed_Acyclic_Graph_2192
{
    public static IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        Dictionary<int, List<int>> connections = new();
        
        foreach (var edge in edges)
        {
            if (!connections.TryGetValue(edge[1], out var value))
            {
                value = [];
                connections[edge[1]] = value;
            }

            value.Add(edge[0]);
        }

        var result = new List<IList<int>>();

        for (var i = 0; i < n; i++)
        {
            HashSet<int> visited = [];
            List<int> current = [];

            DFS(i, connections, visited, current);

            current.Sort();

            result.Add(new List<int>(current));
        }

        return result;
    }

    private static void DFS(int node, IReadOnlyDictionary<int, List<int>> connections, HashSet<int> visited, List<int> current)
    {
        visited.Add(node);

        if (!connections.TryGetValue(node, out var parents))
        {
            return;
        }

        foreach (var parent in parents)
        {
            if (visited.Contains(parent))
            {
                continue;
            }

            current.Add(parent);

            DFS(parent, connections, visited, current);
        }
    }
}