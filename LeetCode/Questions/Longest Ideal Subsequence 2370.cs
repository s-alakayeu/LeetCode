namespace LeetCode.Questions;

public static class Longest_Ideal_Subsequence_2370
{
    public static int LongestIdealString(string s, int k) {
        var n = s.Length;
        var dp = new int[26];
        var maxLen = 0;
        
        for (var i = 0; i < n; i++) {
            var curr = s[i];
            var idx = curr - 'a';
            var best = 0;
            
            for (var prev = 0; prev < 26; prev++) {
                if (Math.Abs(curr - 'a' - prev) <= k) {
                    best = Math.Max(best, dp[prev]);
                }
            }
            
            dp[idx] = best + 1;
            maxLen = Math.Max(maxLen, dp[idx]);
        }
        
        return maxLen;
    }
}