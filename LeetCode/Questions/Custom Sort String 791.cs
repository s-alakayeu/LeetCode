namespace LeetCode.Questions;

public static class Custom_Sort_String_791
{
    public static string CustomSortString(string order, string s)
    {
        var sortOrder = new int[26];

        for (var i = 0; i < order.Length; i++)
        {
            sortOrder[order[i] - 'a'] = i + 1;
        }

        var str = s.ToCharArray();

        Array.Sort(str, (a, b) => sortOrder[a - 'a'] - sortOrder[b - 'a']);

        return new string(str);
    }
}