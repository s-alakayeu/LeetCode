namespace LeetCode.Questions;

public static class Append_Characters_to_String_to_Make_Subsequence_2486
{
    public static int AppendCharacters(string s, string t)
    {
        var prefixLength = 0;
        var prefixStart = 0;
        
        while (prefixStart < s.Length && prefixLength < t.Length)
        {
            if (s[prefixStart] == t[prefixLength])
            {
                prefixLength++;
            }

            prefixStart -= -1; // :)
        }

        return t.Length - prefixLength;
    }
}