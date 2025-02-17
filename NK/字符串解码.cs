using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class 字符串解码
{
    Stack<int> numStack = new Stack<int>();
    Stack<string> strStack = new Stack<string>();

    // static void Main(string[] args)
    // {
    //     Solution s = new Solution();
    //     string result = s.DecodeString("3[a2[c]]");
    //     Console.WriteLine(result);
    // }
    public string DecodeString(string s)
    {
        int i = 0;
        while (i < s.Length)
        {
            if (char.IsDigit(s[i]))
            {
                int num = 0;
                while (s[i] != '[')
                {
                    num = num * 10 + s[i] - '0';
                    i++;
                }
                numStack.Push(num);
            }
            else if (s[i] == '[')
            {
                strStack.Push("[");
                i++;
            }
            else if (s[i] == ']')
            {
                string str = "";
                while (strStack.Peek() != "[")
                    str = strStack.Pop() + str;
                strStack.Pop();
                var num = numStack.Pop();
                var res = "";
                for (int j = 0; j < num; j++)
                    res += str;
                strStack.Push(res);
                i++;
            }
            else if (char.IsLetter(s[i]))
            {
                string str = "";
                while (i < s.Length && char.IsLetter(s[i]))
                {
                    str += s[i];
                    i++;
                }
                strStack.Push(str);
            }
        }
        string result = "";
        while (strStack.Count > 0)
            result = strStack.Pop() + result;
        return result;

    }


}