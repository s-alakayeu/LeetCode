namespace LeetCode.Questions;

public static class Score_of_a_String_3110
{
    public static int ScoreOfString(string s)
    {
        return s
            .Zip(s.Skip(1), (a, b) => Math.Abs(a - b))
            .Sum(); 
    }
}