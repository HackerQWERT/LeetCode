// using System;
// using System.Collections.Generic;


// class Solution
// {
//     // 对于长度为n的一个字符串A（仅包含数字，大小写英文字母），请设计一个高效算法，计算其中最长回文子串的长度。


//     public int getLongestPalindrome(string A)
//     {
//         bool[,] dp = new bool[A.Length, A.Length];
//         for (int i = 0; i < A.Length; i++)
//         {
//             dp[i, i] = true;
//         }
//         int max = 1;
//         for (int j = 0; j < A.Length; j++)
//         {
//             for (int i = 0; i < j; i++)
//             {
//                 if (j - i == 1)
//                 {
//                     dp[i, j] = A[i] == A[j];
//                 }
//                 else
//                 {
//                     dp[i, j] = dp[i + 1, j - 1] && A[i] == A[j];
//                 }
//                 if (dp[i, j])
//                 {
//                     max = Math.Max(max, j - i + 1);
//                 }
//             }
//         }
//         return max;
//     }
// }