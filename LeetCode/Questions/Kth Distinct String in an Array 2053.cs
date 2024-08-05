namespace LeetCode.Questions;

public static class Kth_Distinct_String_in_an_Array_2053
{
    public static string KthDistinct(string[] arr, int k)
    {
        var distinctStrings = arr.GroupBy(x => x, (key, group) => new { Key = key, Count = group.Count() })
            .Where(x => x.Count == 1).ToList();

        if (distinctStrings.Count < k)
        {
            return string.Empty;
        }

        return distinctStrings.Skip(k - 1)
            .First().Key;
    }
}