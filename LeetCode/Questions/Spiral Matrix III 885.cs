namespace LeetCode.Questions;

public static class Spiral_Matrix_III_885
{
    public static int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
    {
        var order = new List<Coordinate>();

        var gridSize = rows * cols;
        var directions = new int[][] { [0, 1], [1, 0], [0, -1], [-1, 0] };

        var direction = 0;
        var step = 1;

        while (order.Count != gridSize)
        {
            for (var i = 0; i < 2; i++)
            {
                for (var j = 0; j < step; j++)
                {
                    if (rStart >= 0 && rStart < rows && cStart >= 0 && cStart < cols)
                    {
                        order.Add(new Coordinate(rStart, cStart));
                    }
                    
                    rStart += directions[direction][0];
                    cStart += directions[direction][1];
                }

                direction = (direction + 1) % 4;
            }

            step++;
        }

        return order.Select(x => new[] { x.Row, x.Column }).ToArray();
    }

    private record struct Coordinate(int Row, int Column);
}