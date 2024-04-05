namespace LeetCode.Questions;

public static class Make_The_String_Great_1544
{
    public static string MakeGood(string s) {
        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1] + 32 || s[i] == s[i - 1] - 32)
            {
                s = s.Remove(i - 1, 2);
                i = 0;
            }
        }
        return s;
    }
}