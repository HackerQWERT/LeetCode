using System;

public class 最长有效括号
{

    public int LongestValidParentheses(string s)
    {
        if (s.Length == 0)
            return 0;
        int max = 0;
        int[] dp = new int[s.Length];
        dp[0] = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == '(')
                dp[i] = 0;
            else
            {
                int lastValid = dp[i - 1];
                if (i - lastValid - 1 < 0)
                    dp[i] = 0;
                else if (s[i - lastValid - 1] == ')')
                    dp[i] = 0;
                else
                {
                    dp[i] = lastValid + 2 + ((i - lastValid - 2) >= 0 ? dp[i - lastValid - 2] : 0);
                    max = Math.Max(max, dp[i]);
                }
            }
        }
        return max;
    }
}