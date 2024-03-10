namespace LeetCode.Questions;

public static class Intersection_of_Two_Arrays_349
{
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums1)
        {
            dict.TryAdd(num, 1);
        }

        foreach (var num in nums2)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
        }

        return dict.Where(x => x.Value >= 2).Select(x => x.Key).ToArray();
    }
}