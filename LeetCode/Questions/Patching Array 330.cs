namespace LeetCode.Questions;

public static class Patching_Array_330
{
    public static int MinPatches(int[] nums, int n)
    {
        var patches = 0;
        var miss = 1;

        for (var i = 0; i < nums.Length;)
        {
            if (nums[i] <= miss)
            {
                miss += nums[i];
                i++;
            }
            else if (nums[i] > miss)
            {
                miss *= 2;
                patches++;
            }
        }

        return patches;
    }
}