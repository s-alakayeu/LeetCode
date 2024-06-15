namespace LeetCode.Questions;

public static class Minimum_Increment_to_Make_Array_Unique_945
{
    public static int MinIncrementForUnique(int[] nums)
    {
        Array.Sort(nums);

        var moves = 0;
        
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                continue;
            }
            
            var difference = nums[i - 1] - nums[i] + 1;
            nums[i] += difference;
            moves += difference;
        }

        return moves;
    }
}