using System;
using System.Collections.Generic;

public class 单词拆分
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var span = s.AsSpan();
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;
        for (int i = 0; i <= span.Length; i++)
        {
            if (dp[i])
                foreach (var word in wordDict)
                {
                    if (s.Length - i >= word.Length && span.Slice(i, word.Length).SequenceEqual(word))
                    {
                        dp[i + word.Length] = true;
                    }
                    // if (i >= word.Length && dp[i - word.Length] && s.Substring(i - word.Length, word.Length) == word)
                    // {
                    //     dp[i] = true;
                    //     break;
                    // }
                }
        }
        return dp[s.Length];
    }
}