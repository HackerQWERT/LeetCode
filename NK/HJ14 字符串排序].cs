// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // 给定 n 个字符串，请对 n 个字符串按照字典序排列。
//         // 输入第一行为一个正整数n(1≤n≤1000),下面n行为n个字符串(字符串长度≤100),字符串中只含有大小写字母。
//         // 输出描述：
//         // 数据输出n行，输出结果为按照字典序排列的字符串，大写字母在小写字母前。
//         int n = int.Parse(Console.ReadLine());
//         List<string> strings = new List<string>(n);

//         // 读取 n 个字符串
//         for (int i = 0; i < n; i++)
//         {
//             strings.Add(Console.ReadLine());
//         }

//         // 按照字典序排序，大写字母在小写字母前
//         var sortedStrings = strings.OrderBy(s => s, StringComparer.Ordinal).ToList();

//         // 输出排序后的字符串
//         foreach (var str in sortedStrings)
//         {
//             Console.WriteLine(str);
//         }
//     }
// }