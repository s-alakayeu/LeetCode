namespace LeetCode.Questions;

public static class Bitwise_AND_of_Numbers_Range_201
{
    public static int RangeBitwiseAnd(int left, int right)
    {
        while (right > left)
        {
            right &= right - 1;
        }

        return right;
    }
}