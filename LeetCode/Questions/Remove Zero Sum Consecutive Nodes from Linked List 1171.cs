using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Remove_Zero_Sum_Consecutive_Nodes_from_Linked_List_1171
{
    public static ListNode PrepareData()
    {
        return new ListNode(1, new ListNode(2, new ListNode(-3, new ListNode(3, new ListNode(1)))));
    }
    
    public static ListNode RemoveZeroSumSublists(ListNode head) {
        var stack = new Stack<int>();
        stack.Push(0);
        var set = new HashSet<int> { 0 };
        var sum = 0;
        var curr = head;
        while (curr != null)
        {
            sum += curr.val;
            if (set.Contains(sum))
            {
                while (stack.Peek() != sum)
                {
                    var item = stack.Pop();
                    set.Remove(item);
                }
            }
            else
            {
                stack.Push(sum);
                set.Add(sum);
            }
            curr = curr.next;
        }
        ListNode rs = null;
        while (stack.Count > 1)
        {
            rs = new ListNode(stack.Pop() - stack.Peek(), rs);
        }
        return rs;
    }
}