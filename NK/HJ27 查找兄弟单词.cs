// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.CompilerServices;

// public class Program
// {
//     public static void Main()
//     {
//         // 定义一个单词的“兄弟单词”为：交换该单词字母顺序（注：可以交换任意次），而不添加、删除、修改原有的字母就能生成的单词。
//         // 兄弟单词要求和原来的单词不同。例如： ab 和 ba 是兄弟单词。 ab 和 ab 则不是兄弟单词。
//         // 现在给定你 n 个单词，另外再给你一个单词 x ，让你寻找 x 的兄弟单词里，按字典序排列后的第 k 个单词是什么？
//         // 注意：字典中可能有重复单词。
//         // 输入描述：
//         // 输入只有一行。 先输入字典中单词的个数n，再输入n个单词作为字典单词。 然后输入一个单词x 最后输入一个整数k
//         // 输出描述：
//         // 第一行输出查找到x的兄弟单词的个数m 第二行输出查找到的按照字典顺序排序后的第k个兄弟单词，没有符合第k个的话则不用输出。
//         var str = Console.ReadLine().Split();
//         int n = int.Parse(str[0]);
//         string[] words = str.Skip(1).Take(n).ToArray();
//         string x = str[n + 1];
//         int k = int.Parse(str[n + 2]);
//         List<string> siblings = new List<string>();
//         var orderX = x.OrderBy(c => c).ToArray();
//         foreach (var word in words)
//         {
//             if (word.Length != x.Length)
//                 continue;
//             else if (word == x)
//                 continue;
//             else if (word.OrderBy(c => c).SequenceEqual(orderX))
//                 siblings.Add(word);
//         }
//         System.Console.WriteLine(siblings.Count);
//         if (k >= siblings.Count)
//             return;
//         siblings.Sort(StringComparer.Ordinal);
//         System.Console.WriteLine(siblings[k - 1]);
//     }
// }