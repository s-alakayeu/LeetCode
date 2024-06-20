namespace LeetCode.Questions;

public static class Magnetic_Force_Between_Two_Balls_1552
{
    public static int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);
        
        var start = 1;
        var end = position[^1] - position[0];
        var force = -1;
        
        while (start <= end)
        {
            var mid = start + (end - start) / 2;

            if (CheckIfDistancePossible(position, m, mid))
            {
                force = mid;
                start = mid + 1;
            }
            else
            {
                end = mid -1;
            }
        }

        return force;
    }

    private static bool CheckIfDistancePossible(int[] positions, int requiredBalls, int distance)
    {
        var balls = 0;
        var previousPosition = int.MinValue;

        foreach (var position in positions)
        {
            if (previousPosition + distance <= position)
            {
                balls++;
                previousPosition = position;

                if (balls == requiredBalls)
                {
                    return true;
                } 
            }
        }

        return false;
    }
}