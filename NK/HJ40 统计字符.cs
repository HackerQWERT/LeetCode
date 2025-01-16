// using System;

// public class Program
// {
//     // 输入一行字符，分别统计出包含英文字母、空格、数字和其它字符的个数。

//     public static void Main()
//     {
//         char[] chars = Console.ReadLine().ToCharArray();

//         int letter = 0;
//         int space = 0;
//         int digit = 0;
//         int other = 0;
//         foreach (var c in chars)
//         {
//             if (char.IsLetter(c))
//                 letter++;
//             else if (char.IsDigit(c))
//                 digit++;
//             else if (char.IsWhiteSpace(c))
//                 space++;
//             else
//                 other++;
//         }
//         System.Console.WriteLine($"{letter}\n{space}\n{digit}\n{other}");

//     }
// }