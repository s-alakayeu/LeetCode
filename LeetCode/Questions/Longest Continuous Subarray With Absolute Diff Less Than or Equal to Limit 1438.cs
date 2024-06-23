namespace LeetCode.Questions;

public static class Longest_Continuous_Subarray_With_Absolute_Diff_Less_Than_or_Equal_to_Limit_1438
{
    public static int LongestSubarray(int[] nums, int limit)
    {
        var maxSize = 0;
        var left = 0;
        var maxQueue = new LinkedList<int>();
        var minQueue = new LinkedList<int>();
        for (var right = 0; right < nums.Length; right++)
        {
            while (maxQueue.Count > 0 && nums[maxQueue.Last.Value] <= nums[right])
            {
                maxQueue.RemoveLast();
            }

            maxQueue.AddLast(right);

            while (minQueue.Count > 0 &&  nums[minQueue.Last.Value] >= nums[right])
            {
                minQueue.RemoveLast();
            }

            minQueue.AddLast(right);

            while (nums[maxQueue.First.Value] - nums[minQueue.First.Value] > limit)
            {
                left++;
                
                if (maxQueue.First.Value < left)
                {
                    maxQueue.RemoveFirst();
                }

                if (minQueue.First.Value < left)
                {
                    minQueue.RemoveFirst();
                }
            }

            maxSize = Math.Max(maxSize, right - left + 1);
        }

        return maxSize;
    }
}