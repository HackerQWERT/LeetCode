public class 搜索二维矩阵

{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][0] <= target && matrix[i][matrix[i].Length - 1] >= target)
            {
                //
                int left = 0;
                int right = matrix[i].Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (matrix[i][mid] == target)
                    {
                        return true;
                    }
                    else if (matrix[i][mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                // for (int j = 0; j < matrix[i].Length; j++)
                // {
                //     if (matrix[i][j] == target)
                //     {
                //         return true;
                //     }
                // }
            }
        }
        return false;

    }
}