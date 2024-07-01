namespace LeetCode.Questions;

public static class Three_Consecutive_Odds_1550
{
    public static bool ThreeConsecutiveOdds(int[] arr)
    {
        const int oddInRowReturnCondition = 3;
        var oddInRow = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                oddInRow = 0;
                continue;
            }

            if (++oddInRow == oddInRowReturnCondition)
            {
                return true;
            }
        }

        return false;
    }
}