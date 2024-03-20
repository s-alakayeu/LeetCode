using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Merge_In_Between_Linked_Lists_1669
{
    public static ListNode PrepareNodeA()
    {
        return new ListNode(10, new ListNode(1, new ListNode(13, new ListNode(6, new ListNode(9, new ListNode(5))))));
    }
    public static ListNode PrepareNodeB()
    {
        return new ListNode(1000000, new ListNode(1000001, new ListNode(1000002)));
    }
    
    public static ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        ListNode dummy = new ListNode(0, list1);
        ListNode prev = dummy;
        
        for (var i = 0; i < a; i++) 
        {
            prev = prev.next;
        }
        
        ListNode curr = prev;
        
        for (var i = a; i <= b; i++) 
        {
            curr = curr.next;
        }
        
        prev.next = list2;
        
        while (list2.next != null) {
            list2 = list2.next;
        }
        
        list2.next = curr.next;
        
        return dummy.next;
    }
}