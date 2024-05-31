namespace LeetCode.Questions;

public static class Single_Number_III_260
{
    public static int[] SingleNumber(int[] nums)
    {
        var result = new List<int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            var isFound = false;
            
            for(var j = 0; j < nums.Length; j++)
            {
                if (i != j && nums[i] == nums[j])
                {
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                result.Add(nums[i]);
            }

            if (result.Count == 2)
            {
                return result.ToArray();
            }
        }

        return new int[2];
    }
}