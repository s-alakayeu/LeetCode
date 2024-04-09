namespace LeetCode.Questions;

public static class Time_Needed_to_Buy_Tickets_2073
{
    public static int TimeRequiredToBuy(int[] tickets, int k) {
        var maxCount = tickets[k];
        var time = 0;

        for (var i = 0; i < tickets.Length; i++)
        {
            time += tickets[i] > maxCount ? maxCount : tickets[i];

            if (i > k && tickets[i] > maxCount - 1)
            {
                time--;
            }
        }

        return time;
    }
}