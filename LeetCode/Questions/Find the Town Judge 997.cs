namespace LeetCode.Questions;

public static class Find_the_Town_Judge_997
{
    public static int FindJudge(int n, int[][] trust)
    {
        var howMuchTrustAPerson = new int[n + 1];
        var whoDoesThePersonTrust = new int[n + 1];

        foreach (var t in trust)
        {
            howMuchTrustAPerson[t[1]]++;
            whoDoesThePersonTrust[t[0]]++;
        }

        for (var i = 1; i <= n; i++)
        {
            if (howMuchTrustAPerson[i] == n - 1 && whoDoesThePersonTrust[i] == 0)
            {
                return i;
            }
        }

        return -1;
    }
}