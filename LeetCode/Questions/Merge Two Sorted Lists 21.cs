using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Merge_Two_Sorted_Lists_21
{

    public static ListNode PrepareData1()
    {
        return new ListNode(1, new ListNode(2, new ListNode(4)));
    }
    
    public static ListNode PrepareData2()
    {
        return new ListNode(1, new ListNode(3, new ListNode(4)));
    }
    
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var temp = new ListNode();
        var head = temp;
        
        while (list1 is not null || list2 is not null)
        {
            var val1 = int.MaxValue;
            
            if (list1 is not null)
            {
                val1 = list1.val;
            }

            var val2 = int.MaxValue;
            
            if (list2 is not null)
            {
                val2 = list2.val;
            }

            if (val1 < val2)
            {
                temp.next = list1;
                temp = temp.next;
                list1 = list1.next;
            }
            else
            {
                temp.next = list2;
                temp = temp.next;
                list2 = list2.next;
            }
        }

        return head.next;
    }
}