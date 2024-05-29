using System.Text;

namespace LeetCode.Questions;

public static class Number_of_Steps_to_Reduce_a_Number_in_Binary_Representation_to_One_1404
{
    public static int NumSteps(string s)
    {
        var builder = new StringBuilder(s);
        var count = 0;
        
        while (builder.Length != 1)
        {
            count++;
            
            if (builder[^1] == '1')
            {
                var index = builder.Length - 1;
                
                builder[index] = '0';

                while (true)
                {
                    index--;

                    if (index < 0)
                    {
                        builder.Append("0", 0, 1);
                        index++;
                    }
                    if (builder[index] > '0')
                    {
                        builder[index] = '0';
                    }
                    else
                    {
                        builder[index] = '1';
                        break;
                    }
                }
            }
            else
            {
                builder.Remove(builder.Length - 1, 1);
            }
        }

        return count;
    }
}