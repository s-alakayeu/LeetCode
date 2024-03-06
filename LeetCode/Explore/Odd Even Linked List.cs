using System.Data;
using LeetCode.Structures;

namespace LeetCode.Explore;

public static class Odd_Even_Linked_List
{
    public static ListNode PrepareData()
    {
        return new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
    }

    public static ListNode OddEvenList(ListNode head)
    {
        if (head?.next == null)
        {
            return head;
        }

        ListNode odd = head;
        ListNode even = head.next;
        ListNode evenHead = even;

        while (even is { next: not null })
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }

        odd.next = evenHead;

        return head;
    }
}