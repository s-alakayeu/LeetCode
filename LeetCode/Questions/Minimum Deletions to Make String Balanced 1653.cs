namespace LeetCode.Questions;

public static class Minimum_Deletions_to_Make_String_Balanced_1653
{
    public static int MinimumDeletions(string s)
    {
        var leftDeletes = 0;
        var rightDeletes = 0;
        var arrayOfA = new int[s.Length];
        var arrayOfB = new int[s.Length];

        for (var i = 0; i < s.Length; i++)
        {
            arrayOfA[i] = leftDeletes;
            if (s[i] == 'b')
            {
                leftDeletes++;
            }
        }

        for (var i = s.Length - 1; i >= 0; i--)
        {
            arrayOfB[i] = rightDeletes;
            if (s[i] == 'a')
            {
                rightDeletes++;
            }
        }

        var minDeletions = s.Length;

        for (var i = 0; i < s.Length; i++)
        {
            minDeletions = Math.Min(minDeletions, arrayOfA[i] + arrayOfB[i]);
        }

        return minDeletions;
    }
}