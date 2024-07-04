#nullable disable

using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Merge_Nodes_in_Between_Zeros_2181
{
    public static ListNode PrepareData()
    {
        ListNode node0 = new ListNode(0);
        ListNode node2 = new ListNode(2, node0);
        ListNode node5 = new ListNode(5, node2);
        ListNode node4 = new ListNode(4, node5);
        ListNode node0Second = new ListNode(0, node4);
        ListNode node1 = new ListNode(1, node0Second);
        ListNode node3 = new ListNode(3, node1);
        ListNode head = new ListNode(0, node3);

        return head;
    }
    public static ListNode MergeNodes(ListNode head)
    {
        var current = head.next;
        var mergedNode = head;
        
        var shouldChangeCurrent = true;
        
        while (current is not null)
        {
            if (current.val == 0)
            {
                shouldChangeCurrent = true;
                mergedNode.next = null;
            }
            else if (shouldChangeCurrent)
            {
                mergedNode.next = current;
                mergedNode = mergedNode.next;
                shouldChangeCurrent = false;
            }
            else
            {
                mergedNode.val += current.val;
            }

            current = current.next;
        }

        return head.next;
    }
}