﻿namespace LeetCode.Questions;

public static class Patching_Array_330
{
    public static int MinPatches(int[] nums, int n)
    {
        var patches = 0;
        long miss = 1;
        var i = 0;
        
        while (miss <= n)
        {
            if (i < nums.Length && nums[i] <= miss)
            {
                miss += nums[i];
                i++;
            }
            else
            {
                miss *= 2;
                patches++;
            }
        }
        
        return patches;
    }
}