namespace LeetCode.Questions;

public static class Hand_of_Straights_846
{
    public static bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
        {
            return false;
        }

        var list = hand.Order().ToList();

        while (list.Count > 0)
        {
            var iterateGroupSize = 0;
            var previousValue = int.MinValue;
            
            foreach (var value in list.ToList())
            {
                if (iterateGroupSize == groupSize)
                {
                    break;
                }
                
                if (previousValue + 1 != value && previousValue != int.MinValue)
                {
                    continue;
                }

                iterateGroupSize++;
                previousValue = value;
                list.Remove(value);
            }

            if (iterateGroupSize != groupSize)
            {
                return false;
            }
        }

        return true;
    }
}