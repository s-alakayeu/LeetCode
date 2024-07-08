namespace LeetCode.Questions;

public static class Find_the_Winner_of_the_Circular_Game_1823
{
    public static int FindTheWinner(int n, int k)
    {
        var players = Enumerable.Range(1, n).ToList();

        var currentIndex = 0;
        
        while (players.Count > 1)
        {
            currentIndex += (k -1);

            if (currentIndex >= players.Count)
            {
                currentIndex %= players.Count;
            }
            
            players.RemoveAt(currentIndex);
        }

        return players.First();
    }
}