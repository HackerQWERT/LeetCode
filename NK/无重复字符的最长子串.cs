using System;
using System.Collections.Generic;

public class 无重复字符的最长子串
{

    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();

        int left = 0, right = 0, max = 0;
        while (right < s.Length)
        {
            if (!set.Contains(s[right]))
            {
                set.Add(s[right]);
                right++;
                max = Math.Max(max, set.Count);
            }
            else
            {
                set.Remove(s[left]);
                left++;
            }
        }

        max = Math.Max(max, right - left);             // 
        return max;

    }
}