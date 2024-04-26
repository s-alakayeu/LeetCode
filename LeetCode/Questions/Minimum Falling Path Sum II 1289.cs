namespace LeetCode.Questions;

public static class Minimum_Falling_Path_Sum_II_1289
{
    public static int MinFallingPathSum(int[][] grid) {
        (int Value, int Index) previousMin1 = (0, -1);
        (int Value, int Index) previousMin2 = (0, -1);

        for (var row = 0; row < grid.Length; row++) {
            (int Value, int Index) currentMin1 = (int.MaxValue, -1);
            (int Value, int Index) currentMin2 = (int.MaxValue, -1);

            for (var column = 0; column < grid.Length; column++)
            {
                var newValue = grid[row][column];
                newValue += column == previousMin1.Index ? previousMin2.Value : previousMin1.Value;
                
                if (newValue < currentMin1.Value) 
                {
                    currentMin2 = currentMin1;
                    currentMin1 = (newValue, column);
                }
                else if (newValue < currentMin2.Value) 
                {
                    currentMin2 = (newValue, column);
                }
            }
            
            previousMin1 = currentMin1;
            previousMin2 = currentMin2;
        }
        
        return previousMin1.Value;
    }
}