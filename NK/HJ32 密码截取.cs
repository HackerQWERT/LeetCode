// using System;

// public class Program
// {
//     public static void Main()
//     {
//         //         Catcher是MCA国的情报员，他工作时发现敌国会用一些对称的密码进行通信，
//         // 比如像这些ABBA，ABA，A，123321，但是他们有时会在开始或结束时加入一些无关的字符以防止别国破解。
//         // 比如进行下列变化 ABBA->12ABBA,ABA->ABAKK,123321->51233214　。因为截获的串太长了，
//         // 而且存在多种可能的情况（abaaab可看作是aba,或baaab的加密形式），Cathcer的工作量实在是太大了，
//         // 他只能向电脑高手求助，你能帮Catcher找出最长的有效密码串吗？
//         // 输入描述：
//         // 输入一个字符串（字符串的长度不超过2500）
//         // 输出描述：
//         // 返回有效密码串的最大长度
//         char[] chars = System.Console.ReadLine().ToCharArray();
//         int max = 1;
//         int n = chars.Length;
//         bool[,] dp = new bool[n, n];
//         for (int i = 0; i < n; i++)
//             dp[i, i] = true;
//         for (int j = 0; j < n; j++)
//         {
//             for (int i = 0; i < j; i++)
//             {
//                 if (j - i == 1 && chars[i] == chars[j])
//                 {
//                     dp[i, j] = true;
//                     max = Math.Max(max, j - i + 1);
//                 }
//                 else if (j - i > 1 && chars[i] == chars[j] && dp[i + 1, j - 1])
//                 {
//                     dp[i, j] = true;
//                     max = Math.Max(max, j - i + 1);
//                 }
//             }
//         }
//         System.Console.WriteLine(max);
//     }
// }