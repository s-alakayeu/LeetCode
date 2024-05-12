namespace LeetCode.Questions;

public static class Largest_Local_Values_in_a_Matrix_2373
{
    public static int[][] LargestLocal(int[][] grid)
    {
        var result = new int[grid.Length - 2][];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = new int[grid.Length - 2];

            for (var j = 0; j < result[i].Length; j++)
            {
                result[i][j] = FindLargest(grid, i, j);
            }
        }

        return result;
    }

    private static int FindLargest(int[][]grid, int x, int y)
    {
        var max = 0;
        
        for (var i = x; i < x + 3; i++)
        {
            for (var j = y; j < y + 3; j++)
            {
                max = Math.Max(grid[i][j], max);
            }
        }

        return max;
    }
}