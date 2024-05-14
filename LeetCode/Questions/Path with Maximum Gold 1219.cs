namespace LeetCode.Questions;

public static class Path_with_Maximum_Gold_1219
{
    private const int DirectionCount = 4;
    private static readonly int[] _rowDirections    = [0, 1, 0, -1];
    private static readonly int[] _columnDirections = [1, 0, -1, 0];
    
    public static int GetMaximumGold(int[][] grid)
    {
        var maxGold = 0;

        for (var row = 0; row < grid.Length; row++)
        {
            for (var column = 0; column < grid[row].Length; column++)
            {
                maxGold = Math.Max(maxGold, DFSBacktrack(grid, row, column));
            }
        }

        return maxGold;
    }
    
    private static int DFSBacktrack(int[][] grid, int row, int column)
    {
        if (row == grid.Length || column == grid[row].Length || grid[row][column] == 0)
        {
            return 0;
        }
        
        var cellValue = grid[row][column];
        grid[row][column] = 0;

        var maxGold = 0;
        
        for (var direction = 0; direction < DirectionCount; direction++)
        {
            if (_rowDirections[direction] + row < 0 || _columnDirections[direction] + column < 0)
            {
                continue;
            }
            
            maxGold = Math.Max(maxGold, 
                DFSBacktrack(grid, _rowDirections[direction] + row, _columnDirections[direction] + column));
        }

        grid[row][column] = cellValue;
        return maxGold + cellValue;
    }
}