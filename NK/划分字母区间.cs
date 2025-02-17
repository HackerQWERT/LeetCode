
using System;
using System.Collections.Generic;

public class 划分字母区间
{

    public IList<int> PartitionLabels(string s)
    {
        Dictionary<char, int> last = new Dictionary<char, int>();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (!last.ContainsKey(s[i]))
            {
                last.Add(s[i], i);
            }
        }
        int start = 0;
        int end = 0;
        int now = 0;
        List<int> result = new List<int>();
        while (true)
        {
            if (now >= s.Length)
            {
                break;
            }
            end = Math.Max(end, last[s[now]]);
            if (now == end)
            {
                result.Add(end - start + 1);
                start = end + 1;
                end = start;
            }
            now++;
        }
        return result;

    }
}
