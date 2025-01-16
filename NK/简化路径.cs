using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class 简化路径
{
    public string SimplifyPath(string path)
    {
        List<string> pathList = path.Split('/', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
        Stack<string> stack = new Stack<string>();
        foreach (var item in pathList)
        {
            if (item == "..")
            {
                if (stack.Count > 0)
                    stack.Pop();
            }
            else if (item == ".")
                continue;
            else
                stack.Push(item);
        }
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in stack)
        {
            stringBuilder.Insert(0, item);
            stringBuilder.Insert(0, "/");
        }
        return stringBuilder.Length == 0 ? "/" : stringBuilder.ToString();
    }
}