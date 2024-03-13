namespace LeetCode.Questions;

public static class Height_Checker_1051
{
    public static int HeightChecker(int[] heights)
    {
        var expected = new int[heights.Length];
        
        heights.CopyTo(expected, 0);
        
        // Bubble sort.
        var hasSwapped = true;
            
        while (hasSwapped) {
            
            hasSwapped = false;
            
            for (var i = 0; i < expected.Length - 1; i++)
            {
                if (expected[i] > expected[i + 1])
                {
                    hasSwapped = true;
                    var temp = expected[i];
                    expected[i] = expected[i + 1];
                    expected[i + 1] = temp;
                }
            }
        }
        
        var missMatch = 0;
        for (var i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
            {
                missMatch++;
            }
        }
        
        return missMatch;
    }
}