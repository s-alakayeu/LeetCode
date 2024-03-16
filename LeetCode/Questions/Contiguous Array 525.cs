namespace LeetCode.Questions;

public static class Contiguous_Array_525
{
    public static int FindMaxLength(int[] nums) {
        var sumToIndex = new Dictionary<int, int> {[0] = -1};
        var sum = 0;
        var max = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i] == 1 ? 1 : -1;

            if (sumToIndex.TryGetValue(sum, out var value))
            {
                max = Math.Max(max, i - value);
            }
            else
            {
                sumToIndex[sum] = i;
            }
        }

        return max;
    }
}