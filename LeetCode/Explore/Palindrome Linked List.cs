using LeetCode.Structures;

namespace LeetCode.Explore;

public static class Palindrome_Linked_List
{
    public static ListNode PrepareData()
    {
        return new ListNode(1, new ListNode(2));
    }
    
    public static bool IsPalindrome(ListNode head) 
    {
        var slow = head;

        var stack = new Stack<int>();

        while (slow != null)
        {
            stack.Push(slow.val);
            slow = slow.next;
        }

        while (head != null)
        {
            var i = stack.Pop();
            if (head.val != i)
            {
                return false;
            }

            head = head.next;
        }

        return true;
    }
}