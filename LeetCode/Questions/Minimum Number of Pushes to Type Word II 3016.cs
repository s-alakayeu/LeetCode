namespace LeetCode.Questions;

public static class Minimum_Number_of_Pushes_to_Type_Word_II_3016
{
    public static int MinimumPushes(string word)
    {
        var letters = new Dictionary<int, int>();

        foreach (var letter in word)
        {
            if (!letters.TryAdd(letter, 1))
            {
                letters[letter]++;
            }
        }

        var orderedDictionary = letters.OrderByDescending(x => x.Value).ToList();

        const int availableKeypads = 8;
        
        var result = 0;

        for (var i = 0; i < orderedDictionary.Count; i++)
        {
            var count = i / availableKeypads + 1;
            result += orderedDictionary[i].Value * count;
        }

        return result;
    }
}