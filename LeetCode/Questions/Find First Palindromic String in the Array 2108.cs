namespace LeetCode.Questions;

public static class Find_First_Palindromic_String_in_the_Array_2108
{
    public static string FirstPalindrome(string[] words) {
        bool isPalindrome;
        foreach(var word in words)
        {
            isPalindrome = true;
            for(int i = 0, j = word.Length - 1; i < j; i++, j--)
            {
                if (word[i] != word[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                return word;
            }
        }

        return "";
    }
}