namespace LeetCode.Questions;

public static class Relative_Sort_Array_1122
{
    public static int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        Array.Sort(arr1);

        var lastInsertedIndex = 0;
        
        for (var i = 0; i < arr2.Length; i++)
        {
            for (var j = lastInsertedIndex; j < arr1.Length; j++)
            {
                if (arr2[i] == arr1[j])
                {
                    (arr1[lastInsertedIndex], arr1[j]) = (arr1[j], arr1[lastInsertedIndex++]);
                }
            }
        }

        var sortedEnd = arr1.Skip(lastInsertedIndex).ToArray();
        Array.Sort(sortedEnd);

        var result = arr1.Take(lastInsertedIndex).Concat(sortedEnd).ToArray();

        return result;
    }
}