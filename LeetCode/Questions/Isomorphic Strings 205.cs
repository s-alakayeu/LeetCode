namespace LeetCode.Questions;

public static class Isomorphic_Strings_205
{
    public static bool IsIsomorphic(string s, string t) {
        
        if (s.Length != t.Length)
        {
            return false;
        }

        var hashSet = new HashSet<char>();
        var links = new Dictionary<char, char>();
        
        for (var i = 0; i < s.Length; i++)
        {
            links.TryGetValue(s[i], out var letter);
            
            if (letter != default)
            {
                if (letter != t[i])
                {
                    return false;
                }

                continue;
            }
            
            if (hashSet.Contains(t[i]))
            {
                return false;
            }

            links[s[i]] = t[i];
            hashSet.Add(t[i]);
        }

        return true;
    }
}