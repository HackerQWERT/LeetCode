using System;
using System.Collections.Generic;
using System.Linq;

public class 字母异位词分组
{

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            var key = new string(str.OrderBy(c => c).ToArray());
            if (dict.ContainsKey(key))
                dict[key].Add(str);
            else
                dict.Add(key, new List<string> { str });
        }
        return dict.Values.ToList<IList<string>>();
    }
}

