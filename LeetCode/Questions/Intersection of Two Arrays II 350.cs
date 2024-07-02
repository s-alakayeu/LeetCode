namespace LeetCode.Questions;

public static class Intersection_of_Two_Arrays_II_350
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        var intersect = new List<int>();

        for (var i = 0; i < nums1.Length; i++)
        {
            for (var j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] >= 0 && nums2[j] >= 0 && nums1[i] == nums2[j])
                {
                    intersect.Add(nums1[i]);
                    nums1[i] = int.MinValue;
                    nums2[j] = int.MinValue;
                }
            }
        }
        
        return intersect.ToArray();
    }
}