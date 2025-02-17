using System;
using System.Collections.Generic;
using System.Text;

public class 括号生成
{
    private IList<string> result = new List<string>();
    private int n;
    private StringBuilder sb = new StringBuilder();
    public IList<string> GenerateParenthesis(int n)
    {
        this.n = n;
        GenerateParenthesis(0, 0);
        return result;
    }

    private void GenerateParenthesis(int leftCount, int rightCount)
    {
        if (leftCount == n && leftCount == rightCount)
        {
            result.Add(sb.ToString());
            return;
        }
        else if (leftCount == n && rightCount < n)
        {
            sb.Append(')');
            GenerateParenthesis(leftCount, rightCount + 1);
            sb.Length--;
            // v = v.PadRight(n * 2, ')');
            // result.Add(v);
            // return;
        }
        else if (leftCount > rightCount)
        {
            sb.Append('(');
            GenerateParenthesis(leftCount + 1, rightCount);
            sb.Length--;

            sb.Append(')');
            GenerateParenthesis(leftCount, rightCount + 1);
            sb.Length--;
        }
        else if (leftCount == rightCount)
        {
            sb.Append('(');
            GenerateParenthesis(leftCount + 1, rightCount);
            sb.Length--;
        }

    }
}