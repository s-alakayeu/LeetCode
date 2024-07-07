namespace LeetCode.Questions;

public static class Water_Bottles_1518
{
    public static int NumWaterBottles(int numBottles, int numExchange)
    {
        var total = 0;
        var bottles = numBottles;
        
        while (numBottles > 0)
        {
            total += numBottles;
            
            numBottles = bottles / numExchange;
            
            var remainingBottles = bottles % numExchange;
            
            bottles = numBottles + remainingBottles;
        }

        return total;
    }
}