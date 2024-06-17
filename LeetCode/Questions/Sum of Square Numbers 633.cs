namespace LeetCode.Questions;

public static class Sum_of_Square_Numbers_633
{
    public static bool JudgeSquareSum(int c)
    {
        var left = 0;
        var right = (int)Math.Sqrt(c);

        while (left <= right)
        {
            var sumOfSquares = left * left + right * right;

            if (sumOfSquares == c)
            {
                return true;
            }

            if (sumOfSquares < c)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return false;
    }
}