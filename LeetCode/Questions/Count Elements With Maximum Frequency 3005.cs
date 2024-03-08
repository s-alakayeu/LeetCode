namespace LeetCode.Questions;

public static class Count_Elements_With_Maximum_Frequency_3005
{
    public static int MaxFrequencyElements(int[] nums)
    {
       return nums.GroupBy(n => n)
           .GroupBy(g => g.Count())
           .MaxBy(g => g.Key)
           .Sum(g => g.Count());
    }
}