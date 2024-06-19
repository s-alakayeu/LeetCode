namespace LeetCode.Questions;

public static class Minimum_Number_of_Days_to_Make_m_Bouquets_1482
{
    public static int MinDays(int[] bloomDay, int m, int k)
    {
        var start = bloomDay.Min();
        var end = bloomDay.Max();

        var minDays = -1;

        while (start <= end)
        {
            var mid = start + (end - start) / 2;

            if (GetNumberOfBouquets(bloomDay, mid, k, m) >= m)
            {
                minDays = mid;
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return minDays;
    }

    private static int GetNumberOfBouquets(int[] bloomDay, int mid, int size, int bouquetsRequested)
    {
        var bouquetsCount = 0;
        var count = 0;

        for (var i = 0; i < bloomDay.Length; i++)
        {
            if (bloomDay[i] <= mid)
            {
                count++;
            }
            else
            {
                count = 0;
            }

            if (count == size)
            {
                bouquetsCount++;
                count = 0;
            }

            if (bouquetsCount == bouquetsRequested)
            {
                return bouquetsCount;
            }
        }

        return bouquetsCount;
    }
}