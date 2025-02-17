using System;

public class 最长回文子串
{

    public string LongestPalindrome(string s)
    {
        bool[][] dp = new bool[s.Length][];
        for (int i = 0; i < s.Length; i++)
            dp[i] = new bool[s.Length];
        int length = 1;
        int start = 0;

        for (int i = 0; i < s.Length; i++)
            dp[i][i] = true;

        for (int j = 0; j < s.Length; j++)
        {
            for (int i = 0; i < j; i++)
            {
                if (s[i] == s[j] && (j - i == 1 || dp[i + 1][j - 1]))
                {
                    dp[i][j] = true;
                    if (j - i + 1 > length)
                    {
                        length = j - i + 1;
                        start = i;
                    }
                }
            }
        }
        return s.Substring(start, length);

    }
}