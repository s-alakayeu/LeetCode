namespace LeetCode.Explore;

public class HeapSort
{
    public static int[] SortArray(int[] nums)
    {
        var size = nums.Length;
        
        if (size <= 1)
            return nums;

        for (var i = size / 2 - 1; i >= 0; i--)
        {
            Heapify(nums, size, i);
        }

        for (var i = size - 1; i >= 0; i--)
        {
            (nums[0], nums[i]) = (nums[i], nums[0]);

            Heapify(nums, i, 0);
        }

        return nums;
    }

    private static void Heapify(int[] array, int size, int index)
    {
        var largestIndex = index;
        var leftChild = 2 * index + 1;
        var rightChild = 2 * index + 2;

        if (leftChild < size && array[leftChild] > array[largestIndex])
        {
            largestIndex = leftChild;
        }

        if (rightChild < size && array[rightChild] > array[largestIndex])
        {
            largestIndex = rightChild;
        }

        if (largestIndex != index)
        {
            (array[index], array[largestIndex]) = (array[largestIndex], array[index]);

            Heapify(array, size, largestIndex);
        }
    }
}