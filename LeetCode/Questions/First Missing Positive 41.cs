namespace LeetCode.Questions;

public static class First_Missing_Positive_41
{
    public static int FirstMissingPositive(int[] nums)
    {
        var n = nums.Length;
        
        var nonPositiveIndex = 0;
        for (var i = 0; i < n; i++) {
            if (nums[i] <= 0) {
                (nums[i], nums[nonPositiveIndex]) = (nums[nonPositiveIndex], nums[i]);
                
                nonPositiveIndex++;
            }
        }
        
        for (var i = nonPositiveIndex; i < n; i++) {
            var num = Math.Abs(nums[i]);
            if (num <= n - nonPositiveIndex && nums[num - 1 + nonPositiveIndex] > 0) {
                nums[num - 1 + nonPositiveIndex] *= -1;
            }
        }
        
        for (var i = nonPositiveIndex; i < n; i++) {
            if (nums[i] > 0) {
                return i - nonPositiveIndex + 1;
            }
        }
        
        return n - nonPositiveIndex + 1;
    }
}