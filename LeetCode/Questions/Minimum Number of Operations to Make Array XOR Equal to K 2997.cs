namespace LeetCode.Questions;

public static class Minimum_Number_of_Operations_to_Make_Array_XOR_Equal_to_K_2997
{
    public static int MinOperations(int[] nums, int k) {
        var operations = 0;
        
        var xor = nums.Aggregate(0, (current, num) => current ^ num);

        if (xor == k) {
            return 0;
        }
        
        var target = xor ^ k;
        
        while (target > 0) {
            operations++;
            target &= (target - 1);
        }
        
        return operations;
    }
}