namespace LeetCode.Questions;

public static class Relative_Ranks_506
{
    public static string[] FindRelativeRanks(int[] score) {
        const string firstPlace = "Gold Medal";
        const string secondPlace = "Silver Medal";
        const string thirdPlace = "Bronze Medal";

        var stringScore = new string[score.Length];
        
        var orderedScore = score.OrderDescending().ToArray();

        for (var i = 0; i < score.Length; i++)
        {
            for (var j = 0; j < score.Length; j++)
            {
                if (score[i] != orderedScore[j])
                {
                    continue;
                }

                stringScore[i] = j switch
                {
                    0 => firstPlace,
                    1 => secondPlace,
                    2 => thirdPlace,
                    _ => (j + 1).ToString()
                };

                break;
            }
        }

        return stringScore;
    }
}