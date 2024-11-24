// using System;
// using System.Collections.Generic;

// public class Program
// {
//     public static void Main()
//     {

//         //编写一个函数，计算字符串中含有的不同字符的个数。
//         //字符在 ASCII 码范围内( 0~127 ，包括 0 和 127 )，
//         //换行表示结束符，不算在字符里。不在范围内的不作统计。
//         //多个相同的字符只计算一次例如，对于字符串 abaca 而言，有 a、b、c 三种不同的字符，因此输出  3
//         string str = Console.ReadLine();
//         if (str == null)
//             return;
//         HashSet<char> hashSet = new HashSet<char>();
//         foreach (var item in str)
//             hashSet.Add(item);
//         System.Console.WriteLine(hashSet.Count);

//     }
// }