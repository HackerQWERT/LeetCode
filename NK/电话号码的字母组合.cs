using System;
using System.Collections.Generic;

public class 电话号码的字母组合
{
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
    public IList<string> LetterCombinations(string digits)
    {

        if (digits.Length == 0)
            return res;
        DFS(digits, 0, "");
        return res;
    }

    private void DFS(string digits, int index, string result)
    {
        if (index == digits.Length)
        {
            res.Add(result);
            return;
        }
        char num = digits[index];
        foreach (char c in dict[num])
            DFS(digits, index + 1, result + c);
    }

}