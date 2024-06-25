using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Binary_Search_Tree_to_Greater_Sum_Tree_1038
{

    public static TreeNode PrepareData()
    {
        var node0 = new TreeNode(0);
        var node2 = new TreeNode(2);
        var node3 = new TreeNode(3);
        var node5 = new TreeNode(5);
        var node7 = new TreeNode(7);
        var node8 = new TreeNode(8);
        var node1 = new TreeNode(1, node0, node2);
        var node6 = new TreeNode(6, node5, node7);
        node2.right = node3;
        node7.right = node8;
        var node4 = new TreeNode(4, node1, node6);

        return node4;
    }
    
    public static TreeNode BstToGst(TreeNode root)
    {
        var result = 0;
        
        DFSRightFirst(root, ref result);

        return root;
    }

    private static void DFSRightFirst(TreeNode node, ref int result)
    {
        if (node is null)
        {
            return;
        }

        if (node.right is not null)
        {
            DFSRightFirst(node.right, ref result);
        }

        result += node.val;
        
        node.val = result;

        if (node.left is not null)
        {
            DFSRightFirst(node.left, ref result);
        }
    }
}