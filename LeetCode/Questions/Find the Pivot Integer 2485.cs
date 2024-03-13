namespace LeetCode.Questions;

public static class Find_the_Pivot_Integer_2485
{
    public static int PivotInteger(int n)
    {
        var pivot = Math.Sqrt(n * (n + 1) / (double)2);
        if (pivot - Math.Floor(pivot) == 0)
        {
            return (int)pivot;   
        }
        
        return -1;
    }
}