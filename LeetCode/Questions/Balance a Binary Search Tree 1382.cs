#nullable disable

using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Balance_a_Binary_Search_Tree_1382
{
    public static TreeNode PrepareData()
    {
        TreeNode node4 = new TreeNode(4);
        TreeNode node3 = new TreeNode(3, null, node4);
        TreeNode node2 = new TreeNode(2, null, node3);
        TreeNode root = new TreeNode(1, null, node2);
        return root;
    }

    public static TreeNode BalanceBST(TreeNode root)
    {
        var inOrderList = new List<TreeNode>();
        
        InOrderTravel(root, inOrderList);

        var result = BSTBalanceTree(inOrderList, 0, inOrderList.Count - 1);
        
        return result;
    }

    private static void InOrderTravel(TreeNode node, List<TreeNode> nodes)
    {
        if (node is null)
        {
            return;
        }

        if (node.left is not null)
        {
            InOrderTravel(node.left, nodes);
        }
        
        nodes.Add(node);
        
        if (node.right is not null)
        {
            InOrderTravel(node.right, nodes);
        }
    }

    private static TreeNode BSTBalanceTree(List<TreeNode> nodes, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        var mid = start + (end - start) / 2;
        
        var leftSubTree = BSTBalanceTree(nodes, start, mid - 1);
        var rightSubTree = BSTBalanceTree(nodes, mid + 1, end);

        var node = nodes[mid];

        node.left = leftSubTree;
        node.right = rightSubTree;

        return node;
    }
}