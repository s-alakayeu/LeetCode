namespace LeetCode.Questions;

public static class Find_All_Duplicates_in_an_Array_442
{
    public static IList<int> FindDuplicates(int[] nums)
    {
        var duplicates = new List<int>();
        
        Array.Sort(nums);

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                duplicates.Add(nums[i]);
                i++;
            }
        }

        return duplicates;
    }
}