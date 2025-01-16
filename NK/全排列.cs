// // 题目描述
// // 给定一个只包含大写英文字母的字符串S，要求你给出对S重新排列的所有不相同的排列数。
// // 如：S为ABA，则不同的排列有ABA、AAB、BAA三种。

// // 解答要求
// // 时间限制：5000ms, 内存限制：100MB
// // 输入
// // 输入一个长度不超过10的字符串S，我们确保都是大写的。

// // 输出
// // 输出S重新排列的所有不相同的排列数（包含自己本身）。

// // 样例
// // 输入样例 1 复制

// // ABA
// // 输出样例 1

// // 3
// // 提示样例 1


// // 输入样例 2 复制

// // ABCDEFGHHA
// // 输出样例 2

// // 907200
// using System;
// using System.Collections.Generic;
// using System.Diagnostics;

// class Program
// {
//     static HashSet<string> set = new HashSet<string>();
//     static void Main(string[] args)
//     {
//         char[] s = Console.ReadLine().ToCharArray();

//         Stopwatch stopwatch = new Stopwatch();
//         stopwatch.Start();

//         DFS(s, "");
//         Console.WriteLine(set.Count);

//         stopwatch.Stop();
//         Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");

//         long memoryUsed = GC.GetTotalMemory(true);
//         Console.WriteLine($"Memory used: {memoryUsed / 1024} KB");
//     }
//     static void DFS(char[] chars, string s)
//     {
//         if (chars.Length == 0)
//             set.Add(s);
//         HashSet<char> charSet = new HashSet<char>();
//         for (int i = 0; i < chars.Length; i++)
//         {
//             if (charSet.Contains(chars[i]))
//                 continue;
//             charSet.Add(chars[i]);
//             char[] newChars = new char[chars.Length - 1];
//             Array.Copy(chars, 0, newChars, 0, i);
//             Array.Copy(chars, i + 1, newChars, i, newChars.Length - i);
//             DFS(newChars, s + chars[i]);
//             // DFS(chars[0..i] + chars[(i + 1)..], s + chars[i]);
//         }
//     }

// }