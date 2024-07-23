namespace LeetCode.Questions;

 public static class Sort_Array_by_Increasing_Frequency_1636
{
    public static int[] FrequencySort(int[] nums)
    {
        var frequency = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (!frequency.TryAdd(nums[i], 1))
            {
                frequency[nums[i]]++;
            }
        }

        var order = frequency.OrderBy(x => x.Value).ThenByDescending(x => x.Key);
        var sorted = order.SelectMany(x => Enumerable.Repeat(x.Key, x.Value)).ToArray();
        
        return sorted;
    }
}