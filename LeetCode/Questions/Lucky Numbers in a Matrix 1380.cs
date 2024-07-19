namespace LeetCode.Questions;

public class Lucky_Numbers_in_a_Matrix_1380
{
    public static IList<int> LuckyNumbers(int[][] matrix)
    {
        var minRows = Enumerable.Repeat(int.MaxValue, matrix.Length).ToArray();
        var maxColumns = Enumerable.Repeat(int.MinValue, matrix[0].Length).ToArray();

        for (var row = 0; row < matrix.Length; row++)
        {
            for (var column = 0; column < matrix[row].Length; column++)
            {
                if (matrix[row][column] < minRows[row])
                {
                    minRows[row] = matrix[row][column];
                }

                if (matrix[row][column] > maxColumns[column])
                {
                    maxColumns[column] = matrix[row][column];
                }
            }
        }

        return minRows.Intersect(maxColumns).ToList();
    }
}