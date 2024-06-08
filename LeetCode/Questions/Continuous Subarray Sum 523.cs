namespace LeetCode.Questions;

public static class Continuous_Subarray_Sum_523
{
    public static bool CheckSubarraySum(int[] nums, int k)
    {
        var prefixSum = nums[0] % k;

        var prefixSumSet = new HashSet<int>();

        for (var i = 1; i < nums.Length; i++)
        {
            var result = (prefixSum + nums[i]) % k;

            if (result % k == 0 || prefixSumSet.Contains(result))
            {
                return true;
            }

            prefixSumSet.Add(prefixSum);

            prefixSum = result;
        }

        return false;
    }
}