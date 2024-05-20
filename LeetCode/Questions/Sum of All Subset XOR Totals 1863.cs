namespace LeetCode.Questions;

public static class Sum_of_All_Subset_XOR_Totals_1863
{
    public static int SubsetXORSum(int[] nums) 
    {
        return Helper(nums, 0, 0);
    }

    private static int Helper(int[] nums, int index, int currValue) 
    {
        if (index == nums.Length)
        {
            return currValue;
        }
        
        return Helper(nums, index + 1, currValue ^ nums[index]) + Helper(nums, index + 1, currValue);
    }
}