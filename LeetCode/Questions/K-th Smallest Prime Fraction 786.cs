namespace LeetCode.Questions;

public static class K_th_Smallest_Prime_Fraction_786
{
    public static int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        var factors = new Dictionary<double, int[]>();

        for (var i = 0; i < arr.Length; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                factors.Add(Math.Round((double)arr[i] / arr[j], 10), [arr[i], arr[j]]);
            }
        }

        var key = factors.Keys.Order().ElementAt(k - 1);
        
        return factors[key];
    }
}