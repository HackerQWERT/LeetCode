using System;
using System.Linq;

public class H指数
{
    public int HIndex(int[] citations)
    {
        int h = 0;
        var sortNums = citations.OrderByDescending(x => x).ToArray();
        for (int i = 0; i <= sortNums.Length - 1; i++)
        {
            if (sortNums[i] >= i + 1)
            {
                h = i + 1;
            }
            else
            {
                break;
            }
        }
        return h;

    }
}