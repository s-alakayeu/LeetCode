namespace LeetCode.Questions;

public static class Reveal_Cards_In_Increasing_Order_950
{
    public static int[] DeckRevealedIncreasing(int[] deck)
    {
        Array.Sort(deck, (x, y) => y.CompareTo(x));
        
        var queue = new Queue<int>();
        
        queue.Enqueue(deck[0]);

        for (var i = 1; i < deck.Length; i++)
        {
            queue.Enqueue(queue.Dequeue());
            
            queue.Enqueue(deck[i]);
        }

        return queue.Reverse().ToArray();
    }
}