namespace LeetCode.Questions;

public static class The_Number_of_Beautiful_Subsets_2597
{
    public static int BeautifulSubsets(int[] nums, int k)
    {
        var count = 0;

        Array.Sort(nums);

        CountBeautifulSubsets(nums, 0, k, new Dictionary<int, int>(), ref count);

        return count;
    }

    private static void CountBeautifulSubsets(int[] nums, int index, int difference, Dictionary<int, int> visited, ref int count)
    {
        if (index == nums.Length)
        {
            return;
        }

        if (!visited.ContainsKey(nums[index] - difference))
        {
            if (!visited.TryAdd(nums[index], 1))
            {
                visited[nums[index]]++;
            }

            count++;
            CountBeautifulSubsets(nums, index + 1, difference, visited, ref count);

            if (visited[nums[index]] > 1)
            {
                visited[nums[index]]--;
            }
            else
            {
                visited.Remove(nums[index]);
            }
        }
        
        CountBeautifulSubsets(nums, index + 1, difference, visited, ref count);
    }
}