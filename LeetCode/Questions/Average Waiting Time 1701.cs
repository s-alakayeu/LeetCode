namespace LeetCode.Questions;

public static class Average_Waiting_Time_1701
{
    public static double AverageWaitingTime(int[][] customers)
    {
        var totalTime = 0;
        var currentTime = 0;

        foreach (var customer in customers)
        {
            if (currentTime < customer[0])
            {
                currentTime = customer[0];
            }

            currentTime += customer[1];

            totalTime += currentTime - customer[0];
        }

        return totalTime / (double)customers.Length;
    }
}