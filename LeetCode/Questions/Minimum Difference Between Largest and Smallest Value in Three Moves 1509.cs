namespace LeetCode.Questions;

public class Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves_1509
{
    public static int MinDifference(int[] nums)
    {
        const int maxMovesCount = 3;
        const int maxLengthWithZeroDifference = maxMovesCount + 1;
        
        if (nums.Length <= maxLengthWithZeroDifference)
        {
            return 0;
        }

        Array.Sort(nums);

        var minimal = nums[^1] - nums[0];
        
        for(var i = 0; i <= maxMovesCount; i++)
        {
            minimal = Math.Min(minimal, nums[nums.Length - 1 - i] - nums[maxMovesCount - i]); 
        }

        return minimal;
    }
}