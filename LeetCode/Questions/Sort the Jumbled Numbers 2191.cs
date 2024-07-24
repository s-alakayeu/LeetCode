namespace LeetCode.Questions;

public static class Sort_the_Jumbled_Numbers_2191
{
    public static int[] SortJumbled(int[] mapping, int[] nums)
    {
        var map = new List<Tuple<int, int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            var value = nums[i].ToString();

            var jumbledValue = 0;
            
            for (var j = 0; j < value.Length; j++)
            {
                jumbledValue *= 10;
                jumbledValue += mapping[value[j] - 48];
            }
            
            map.Add(new Tuple<int, int>(nums[i], jumbledValue));
        }

        var result = map.OrderBy(x => x.Item2).Select(x => x.Item1).ToArray();
        return result;
    }
}