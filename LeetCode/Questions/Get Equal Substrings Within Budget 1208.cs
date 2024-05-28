namespace LeetCode.Questions;

public static class Get_Equal_Substrings_Within_Budget_1208
{
    public static int EqualSubstring(string s, string t, int maxCost)
    {
        var maxSize = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var currentCost = 0;
            var currentSize = 0;

            for (var j = i; j < s.Length; j++)
            {
                var changeCost = Math.Abs(t[j] - s[j]);

                if (changeCost + currentCost > maxCost)
                {
                    break;
                }

                currentCost += changeCost;
                currentSize++;
            }

            if (currentSize > maxSize)
            {
                maxSize = currentSize;
            }
        }

        return maxSize;
    }
}