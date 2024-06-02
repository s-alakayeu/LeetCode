namespace LeetCode.Questions;

public static class Reverse_String_344
{
    public static void ReverseString(char[] s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            var j = s.Length - i - 1;
            (s[i], s[j]) = (s[j], s[i]);
        }
    }
}