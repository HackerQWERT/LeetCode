// using System;
// using System.Collections.Generic;

// public class Program
// {
//     public static void Main()
//     {
//         //输入一个 int 型整数，按照从右向左的阅读顺序，返回一个不含重复数字的新的整数。保证输入的整数最后一位不是 0 。
//         string str = Console.ReadLine();
//         if (str == null)
//             return;
//         HashSet<char> hashSet = new HashSet<char>();
//         for (int i = str.Length - 1; i >= 0; i--)
//             hashSet.Add(str[i]);
//         foreach (var item in hashSet)
//             Console.Write(item);
//     }
// }