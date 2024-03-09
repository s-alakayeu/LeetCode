namespace LeetCode.Questions;

public static class Minimum_Common_Value_2540
{
    public static int GetCommon(int[] nums1, int[] nums2)
    {
        var hashSet = new HashSet<int>(nums1);
        
        foreach (var num in nums2)
        {
            if (hashSet.Contains(num))
            {
                return num;
            }
        }

        return -1;
    }
}