namespace LeetCode.Questions;

public static class Longest_Palindrome_409
{
    public static int LongestPalindrome(string s)
    {
        var hash = new HashSet<char>();
        var maxLength = 0;

        foreach (var c in s)
        {
            if (!hash.Add(c))
            {
                hash.Remove(c);
                maxLength += 2;
            }
        }

        return hash.Count > 0 ? maxLength + 1 : maxLength;
    }
}