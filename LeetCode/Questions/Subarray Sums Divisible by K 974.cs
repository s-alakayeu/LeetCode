namespace LeetCode.Questions;

public static class Subarray_Sums_Divisible_by_K_974
{
    public static int SubarraysDivByK(int[] nums, int k)
    {
        var count = 0;
        var prefixSum = 0;
        var prefixSumArrays = new int[k];
        prefixSumArrays[0] = 1;

        foreach (var num in nums)
        {
            prefixSum = ((prefixSum + num) % k + k) % k;

            count += prefixSumArrays[prefixSum];
            
            prefixSumArrays[prefixSum]++;
        }

        return count;
    }
}