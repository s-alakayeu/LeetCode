namespace LeetCode.Questions;

public static class Score_After_Flipping_Matrix_861
{
    public static int MatrixScore(int[][] grid) {
        for (var i = 0; i < grid.Length; i++)
        {
            if (grid[i][0] != 1)
            {
                FlipRow(grid[i]);
            }
        }

        for (var i = 1; i < grid[0].Length; i++)
        {
            var ones = 0;

            for (var j = 0; j < grid.Length; j++)
            {
                ones += grid[j][i];
            }

            if (ones < (grid.Length + 1) / 2)
            {
                FlipColumn(grid, i);
            }
        }
        
        var score = 0;
        
        for (var i = 0; i < grid.Length; i++) 
        {
            var rowScore = 0;
            
            for (var j = 0; j < grid[i].Length; j++) 
            {
                rowScore = (rowScore << 1) + grid[i][j];
            }
            
            score += rowScore;
        }

        return score;
    }

    private static void FlipRow(int[] row)
    {
        for (var i = 0; i < row.Length; i++)
        {
            row[i] = (row[i] + 1) % 2;
        }
    }

    private static void FlipColumn(int[][] grid, int column)
    {
        for (var i = 0; i < grid.Length; i++)
        {
            grid[i][column] = (grid[i][column] + 1) % 2;
        }
    }
}