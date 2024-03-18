namespace LeetCode.Questions;

public static class Minimum_Number_of_Arrows_to_Burst_Balloons_425
{
    public static int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

        var arrows = 1;
        var prevEnd = points[0][1];

        for (var i = 1; i < points.Length; ++i)
        {
            if (points[i][0] > prevEnd)
            {
                arrows++;
                prevEnd = points[i][1];
            }
        }

        return arrows;
    }
}