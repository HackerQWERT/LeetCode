using System.Text;

public class Z字形变换
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        StringBuilder stringBuilder = new StringBuilder();
        for (int j = 0; j < s.Length; j += 2 * numRows - 2)
        {
            if (j < s.Length)
                stringBuilder.Append(s[j]);
        }
        for (int i = 1; i <= numRows - 2; i++)
        {
            int j = i;
            var gap = 2 * numRows - 2 - i * 2;
            bool flag = true;
            while (true)
            {
                if (j < s.Length)
                    stringBuilder.Append(s[j]);
                if (flag)
                {
                    j += gap;
                    flag = false;
                }
                else
                {
                    j += 2 * i;
                    flag = true;
                }
                if (j >= s.Length)
                    break;
            }
        }
        for (int j = numRows - 1; j < s.Length; j += 2 * numRows - 2)
        {
            if (j < s.Length)
                stringBuilder.Append(s[j]);
        }
        return stringBuilder.ToString();
    }
}