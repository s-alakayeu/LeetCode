namespace LeetCode.Questions;

public static class Special_Array_With_X_Elements_Greater_Than_or_Equal_X_1608
{
    public static int SpecialArray(int[] nums)
    {
        var result = -1;

        Array.Sort(nums);

        for (var i = 0; i <= nums.Length; i++)
        {
            var count = 0;

            foreach (var num in nums)
            {
                if (num >= i)
                {
                    count++;
                }

                if (count > i)
                {
                    break;
                }
            }

            if (count == i)
            {
                result = count;
                break;
            }
        }

        return result;
    }
}