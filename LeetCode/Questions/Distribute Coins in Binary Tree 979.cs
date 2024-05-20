using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Distribute_Coins_in_Binary_Tree_979
{
    public static TreeNode PrepareResult()
    {
        return new TreeNode(0, new TreeNode(3), new TreeNode(0));
    }

    private static int _result;

    public static int DistributeCoins(TreeNode root)
    {
        DFS(root);

        return _result;
    }

    private static int DFS(TreeNode node)
    {
        if (node is null)
        {
            return 0;
        }

        var leftValue = DFS(node.left);
        var rightValue = DFS(node.right);

        _result += Math.Abs(leftValue) + Math.Abs(rightValue);

        return node.val + leftValue + rightValue - 1;
    }
}