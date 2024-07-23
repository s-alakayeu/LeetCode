namespace LeetCode.Questions;

public static class Sort_the_People_2418
{
    public static string[] SortPeople(string[] names, int[] heights) 
        => names.Zip(heights).OrderByDescending(x => x.Second).Select(x => x.First).ToArray();
}