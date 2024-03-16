namespace LeetCode.Questions;

public static class Product_of_Array_Except_Self_238
{
    public static int[] ProductExceptSelf(int[] nums) {
        var answer = new int[nums.Length];

        int left = 1, right = 1;

        for (var i = 0; i < nums.Length; i++)
        {
            answer[i] = right;
            right *= nums[i];
        }

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= left;
            left *= nums[i];
        }

        return answer;
    }
}