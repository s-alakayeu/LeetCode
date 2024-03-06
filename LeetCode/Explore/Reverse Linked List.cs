using LeetCode.Structures;

namespace LeetCode.Explore;

public static class Reverse_Linked_List
{
    public static ListNode PrepareData()
    {
        return new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
    }
    
    public static ListNode ReverseList(ListNode head) {
        ListNode previous = null;
        
        while (head is not null)
        {
            var temp = head?.next;
            head.next = previous;
            previous = head;
            head = temp;
            
        }
        
        return previous;
    }
}