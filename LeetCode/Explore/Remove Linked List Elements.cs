using LeetCode.Structures;

namespace LeetCode.Explore;

public static class Remove_Linked_List_Elements
{
    public static ListNode PrepareData()
    {
        return new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
    }
    
    public static ListNode RemoveElements(ListNode head, int val) {
        var fakeNode = new ListNode(0, head);
        var node = fakeNode;
        
        while (node.next is not null)
        {   
            if (node.next.val != val && fakeNode?.next.val == val)
            {
                fakeNode.next = node.next;
            }
            
            if (node.next.val == val)
            {
                node.next = node.next?.next;
            }
            else
            {
                node = node.next;
            }
        }
        
        return fakeNode.next;
    }
    
}