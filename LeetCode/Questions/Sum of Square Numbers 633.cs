namespace LeetCode.Questions;

public static class Sum_of_Square_Numbers_633
{
    public static bool JudgeSquareSum(int c)
    {
        if (c == 0)
        {
            return true;
        }
        
        for (var firstArgument = 0; firstArgument * firstArgument < c; firstArgument++)
        {
            var secondArgument = c - firstArgument * firstArgument;

            if (BinarySearch(0, secondArgument, secondArgument))
            {
                return true;
            }
        }

        return false;
    }

    private static bool BinarySearch(long start, long end, int secondArgument)
    {
        if (start > end)
        {
            return false;
        }

        long mid = start + (end - start) / 2;

        if (mid * mid == secondArgument)
        {
            return true;
        }

        if (mid * mid > secondArgument)
        {
            return BinarySearch(start, mid - 1, secondArgument);
        }
        
        return BinarySearch(mid + 1, end, secondArgument);
    }
}