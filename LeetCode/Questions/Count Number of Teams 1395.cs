namespace LeetCode.Questions;

public static class Count_Number_of_Teams_1395
{
    private const int CompletedTeamSize = 3;
    public static int NumTeams(int[] rating)
    {
        var teams = 0;

        var increasingCache = new int?[rating.Length, 4];
        var decreasingCache = new int?[rating.Length, 4];
        
        for (var i = 0; i < rating.Length - CompletedTeamSize; i++)
        {
            teams += CalculateIncreasingTeam(rating, i, 1, increasingCache);
            teams += CalculateDecreasingTeam(rating, i, 1, decreasingCache);
        }

        return teams;
    }

    private static int CalculateIncreasingTeam(int[] rating, int index, int teamSize, int?[,] increasingCache)
    {
        if (index == rating.Length)
        {
            return 0;
        }

        if (teamSize == CompletedTeamSize)
        {
            return 1;
        }

        if (increasingCache[index, teamSize].HasValue)
        {
            return increasingCache[index, teamSize].Value;
        }
        
        var validTeams = 0;
        
        for (var i = index + 1; i < rating.Length; i++)
        {
            if (rating[i] <= rating[index])
            {
                continue;
            }

            validTeams += CalculateIncreasingTeam(rating, i, teamSize + 1, increasingCache);
        }

        increasingCache[index, teamSize] = validTeams;
        return validTeams;
    }

    private static int CalculateDecreasingTeam(int[] rating, int index, int teamSize, int?[,] decreasingCache)
    {
        if (index == rating.Length)
        {
            return 0;
        }

        if (teamSize == CompletedTeamSize)
        {
            return 1;
        }
        
        if (decreasingCache[index, teamSize].HasValue)
        {
            return decreasingCache[index, teamSize].Value;
        }
        
        var validTeams = 0;
        
        for (var i = index + 1; i < rating.Length; i++)
        {
            if (rating[i] >= rating[index])
            {
                continue;
            }

            validTeams += CalculateDecreasingTeam(rating, i, teamSize + 1, decreasingCache);
        }

        decreasingCache[index, teamSize] = validTeams;
        return validTeams;
    }
}