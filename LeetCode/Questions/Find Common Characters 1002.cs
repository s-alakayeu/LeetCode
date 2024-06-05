namespace LeetCode.Questions;

public static class Find_Common_Characters_1002
{
    public static IList<string> CommonChars(string[] words)
    {
        var meets = new Dictionary<char, int>();
        
        foreach (var letter in words[0])
        {
            if (!meets.TryAdd(letter, 1))
            {
                meets[letter] += 1;
            }
        }

        for (var index = 1; index < words.Length; index++)
        {
            var word = words[index];
            var localMeets = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (!meets.ContainsKey(letter))
                {
                    continue;
                }

                if (!localMeets.TryAdd(letter, 1))
                {
                    localMeets[letter]++;
                }
            }

            foreach (var meet in meets)
            {
                if (!localMeets.TryGetValue(meet.Key, out var value))
                {
                    meets.Remove(meet.Key);
                }

                else if (value < meet.Value)
                {
                    meets[meet.Key] = value;
                }
            }
        }

        var result = new List<string>();

        foreach (var meet in meets)
        {
            if (meet.Value <= 1)
            {
                result.Add(meet.Key.ToString());
                continue;
            }
            
            for (var i = 0; i < meet.Value; i++)
            {
                result.Add(meet.Key.ToString());
            }
        }

        return result;
    }
}