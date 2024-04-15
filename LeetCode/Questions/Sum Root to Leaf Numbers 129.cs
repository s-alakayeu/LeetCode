using System.Text;
using LeetCode.Structures;

namespace LeetCode.Questions;

public class Sum_Root_to_Leaf_Numbers_129
{
    public static TreeNode PrepareTree() => new TreeNode(1, new TreeNode(2), new TreeNode(3));
    
    public static int SumNumbers(TreeNode root) {
        var sum = 0;
        var currentValue = new StringBuilder();

        BFS(root, ref sum, currentValue);

        return sum;
    }

    private static void BFS(TreeNode node, ref int sum, StringBuilder val)
    {
        val.Append(node.val.ToString());

        if (node.left is not null)
        {
            BFS(node.left, ref sum, val);
        }

        if (node.right is not null)
        {
            BFS(node.right, ref sum, val);
        }

        if (node.right is null && node.left is null)
        {
            sum += Convert.ToInt32(val.ToString());
        }
        
        val.Length--;
    }
}