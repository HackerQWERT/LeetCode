using System;
using System.Linq;

public class 用最少数量的箭引爆气球
{
    public int FindMinArrowShots(int[][] points)
    {
        points = points.OrderBy(x => x[1]).ToArray();

        int arrows = 1;
        int end = points[0][1];
        for (int i = 1; i < points.Length; i++)
        {
            if (points[i][0] > end)
            {
                arrows++;
                end = points[i][1];
            }

        }
        return arrows;
    }

}