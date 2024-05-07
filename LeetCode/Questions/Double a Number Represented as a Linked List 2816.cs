using System.Numerics;
using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Double_a_Number_Represented_as_a_Linked_List_2816
{
    public static ListNode PrepareInput()
    {
        return new ListNode(3,
            new ListNode(4, new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(5, new ListNode(5, new ListNode(9, new ListNode(9, new ListNode(9))))))))));
    }

    public static ListNode DoubleIt(ListNode head)
    {
        var result = string.Empty;

        CalculateList(head, ref result);

        var bigInt = BigInteger.Parse(result);
        bigInt = bigInt * 2;

        var newHead = new ListNode();

        SetList(newHead, bigInt.ToString());

        return newHead;
    }

    private static void CalculateList(ListNode node, ref string result)
    {
        if (result == string.Empty)
        {
            result = node.val.ToString();
        }
        else
        {
            result += node.val.ToString();
        }

        if (node.next is not null)
        {
            CalculateList(node.next, ref result);
        }
    }

    private static void SetList(ListNode node, string result)
    {
        var value = Convert.ToInt32(result[0].ToString());

        node.val = value;

        result = result[1..];

        if (result == string.Empty)
        {
            return;
        }

        var nextNode = new ListNode();

        node.next = nextNode;

        SetList(nextNode, result);
    }
}