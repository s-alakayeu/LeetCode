namespace LeetCode.Questions;

public static class Subarray_Product_Less_Than_K_713
{
    public static int NumSubarrayProductLessThanK(int[] nums, int k) {
        if (k <= 1)
        {
            return 0;
        }
        
        var count = 0;
        var product = 1;
        var left = 0;
        
        for (var right = 0; right < nums.Length; right++) {
            product *= nums[right];
            
            while (product >= k && left <= right) {
                product /= nums[left];
                left++;
            }
            
            count += right - left + 1;
        }
        
        return count;
    }
}