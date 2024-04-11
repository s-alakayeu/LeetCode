using System.Text;

namespace LeetCode.Questions;

public static class Remove_K_Digits_402
{
    public static string RemoveKDigits(string num, int k)
    {
        if (num.Length == k)
        {
            return "0";
        }

        StringBuilder result = new StringBuilder();
        var digitsToRemove = k;
        
        foreach (var digit in num) {
            while (digitsToRemove > 0 && result.Length > 0 && result[^1] > digit) 
            {
                result.Remove(result.Length - 1, 1);
                digitsToRemove--;
            }
            result.Append(digit);
        }
        
        while (digitsToRemove > 0) 
        {
            result.Remove(result.Length - 1, 1);
            digitsToRemove--;
        }
        
        while (result.Length > 1 && result[0] == '0') 
        {
            result.Remove(0, 1);
        }
        
        return result.ToString();
    }
}