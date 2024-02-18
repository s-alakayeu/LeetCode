namespace LeetCode.Questions;

public class Find_Polygon_With_the_Largest_Perimeter_2971
{
    public static long LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        
        var count = nums.Length;
        var prefix = new long[count];
        prefix[0] = nums[0];
        for (var i = 1; i < count; i++)
        {
            prefix[i] = prefix[i - 1] + nums[i];
        }

        for (var i = count - 1; i > 1; i--)
        {
            if (nums[i] < prefix[i - 1])
            {
                return prefix[i];   
            }
        }

        return -1;
    }
}