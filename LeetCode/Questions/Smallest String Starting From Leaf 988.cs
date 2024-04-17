using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Smallest_String_Starting_From_Leaf_988
{
    static string smallest = string.Empty;

    public static TreeNode PrepareNode()
    {
        return new TreeNode(0, new TreeNode(1, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(3), new TreeNode(4)));
    }
    
    public static string SmallestFromLeaf(TreeNode root) {
        DFS(root, string.Empty);

        return smallest;
    }
    
    private static void DFS(TreeNode node, string current)
    {
        current = (char)(node.val + 'a') + current;
        
        if (node.left is null && node.right is null)
        {
            if (string.IsNullOrEmpty(smallest) || smallest.CompareTo(current) > 0)
            {
                smallest = current;
            }
        }

        if (node.left is not null)
        {
            DFS(node.left, current);
        }

        if (node.right is not null)
        {
            DFS(node.right, current);
        }
    }
}