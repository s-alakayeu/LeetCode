using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Leaf_Similar_Trees_872
{

    public static TreeNode GetRoot1()
    {
        var leftLeaf = new TreeNode(2);
        var rightLeaf = new TreeNode(3);

        var root = new TreeNode(1, leftLeaf, rightLeaf);

        return root;
    }
    
    public static TreeNode GetRoot2()
    {
        var leftLeaf = new TreeNode(3);
        var rightLeaf = new TreeNode(2);

        var root = new TreeNode(1, leftLeaf, rightLeaf);

        return root;
    }
    
    public static bool LeafSimilar(TreeNode root1, TreeNode root2) {
        
        var leftSum = "";
        var rightSum = "";

        CLR(root1, ref leftSum);
        CLR(root2, ref rightSum);

        return leftSum == rightSum;
    }

    private static void CLR(TreeNode node, ref string leafSum)
    {
        if (node is null)
        {
            return;
        }

        if (node.left is null && node.right is null)
        {
            leafSum += node.val.ToString();
            return;
        }

        CLR(node.left, ref leafSum);
        CLR(node.right, ref leafSum);
    }
}