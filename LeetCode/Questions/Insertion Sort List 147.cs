using LeetCode.Structures;

namespace LeetCode.Questions;

public static class Insertion_Sort_List_147
{
    public static ListNode PrepareData()
    {
        return new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3))));
    }
    
    public static ListNode InsertionSortList(ListNode head)
    {
        var output = null as ListNode;

        foreach (var input in Enumerate(head))
        {
            ref var node = ref FindInsertion(ref output, input);

            // insert
            input.next = node;
            node = input;
        }

        return output;
    }

    private static IEnumerable<ListNode> Enumerate(ListNode node)
    {
        while (node is not null)
        {
            var next = node.next;
            yield return node;
            node = next;
        }
    }

    private static ref ListNode FindInsertion(ref ListNode output, ListNode input)
    {
        ref var node = ref output;

        while (node != null && node.val < input.val)
        {
            node = ref node.next;
        }

        return ref node;
    }
}

