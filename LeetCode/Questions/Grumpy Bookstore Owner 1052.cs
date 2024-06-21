namespace LeetCode.Questions;

public static class Grumpy_Bookstore_Owner_1052
{
    public static int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        var maxUnsatisfied = 0;

        for (var i = 0; i < minutes; i++)
        {
            maxUnsatisfied += customers[i] * grumpy[i];
        }

        var unsatisfied = maxUnsatisfied;
        
        for (var i = minutes; i < customers.Length; i++)
        {
            unsatisfied += customers[i] * grumpy[i];
            unsatisfied -= customers[i - minutes] * grumpy[i - minutes];

            maxUnsatisfied = Math.Max(maxUnsatisfied, unsatisfied);
        }

        var totalCustomers = maxUnsatisfied;

        for (var j = 0; j < customers.Length; j++)
        {
            totalCustomers += customers[j] * (1 - grumpy[j]);
        }

        return totalCustomers;
    }
}