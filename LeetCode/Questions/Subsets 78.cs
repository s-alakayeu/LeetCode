namespace LeetCode.Questions;

public static class Subsets_78
{
    public static IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>();

        GenerateSubSets(nums, 0, new List<int>(), result);

        return result;
    }

    private static void GenerateSubSets(int[] nums, int index, List<int> current, List<IList<int>> result)
    {
        result.Add(new List<int>(current));

        for (var i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            GenerateSubSets(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}