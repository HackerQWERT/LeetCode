using System;
using System.Collections.Generic;
using System.Text;

public class 电话号码的字母组合
{

    StringBuilder sb = new StringBuilder();
    List<string> res = new List<string>();
    Dictionary<char, string> dict = new Dictionary<char, string>()
    {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };
    string digits;
    public IList<string> LetterCombinations(string digits)
    {

        this.digits = digits;
        if (digits.Length == 0)
            return res;
        DFS(0);
        return res;
    }

    private void DFS(int index)
    {
        if (index == digits.Length)
        {
            res.Add(sb.ToString());
            return;
        }
        char num = digits[index];
        foreach (char c in dict[num])
        {
            sb.Append(c);
            DFS(index + 1);
            sb.Length--;
        }
    }

}