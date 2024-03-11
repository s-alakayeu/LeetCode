using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Add_Two_Numbers_2
{
    public static ListNode PrepareDataFirst()
    {
        //return new ListNode(2, new ListNode(4, new ListNode(3)));
        return new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
    }
    
    public static ListNode PrepareDataSecond()
    {
        //return new ListNode(5, new ListNode(6, new ListNode(4)));
        return new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
    }
    
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var temp = new ListNode();
        var head = temp;

        var nextPart = 0;
        while (l1 is not null || l2 is not null)
        {
            var value = (l1?.val ?? 0) + (l2?.val ?? 0) + nextPart;
            
            if (value >= 10)
            {
                value -= 10;
            }
            
            nextPart = value / 10;

            temp.next = new ListNode(value);
            temp = temp.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (nextPart > 0)
        {
            temp.next = new ListNode(nextPart);
        }
        
        return head.next;
    }
}