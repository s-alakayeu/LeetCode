namespace LeetCode.Questions;

public class Insert_Interval_57
{
    public static int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        
        foreach (var interval in intervals)
        {
            if (interval[0] > newInterval[1])
            {
                result.Add(newInterval);
                newInterval = interval;
            }
            else if (interval[1] < newInterval[0])
            {
                result.Add(interval);
            }
            else
            {
                newInterval[0] = Math.Min(newInterval[0], interval[0]);
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
        }
        
        result.Add(newInterval);
        
        return result.ToArray();
    }
}