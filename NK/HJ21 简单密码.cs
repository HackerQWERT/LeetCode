// using System;

// public class Program
// {
//     public static void Main()
//     {
//         //现在有一种密码变换算法。
//         // 九键手机键盘上的数字与字母的对应： 1--1， abc--2, def--3, ghi--4, jkl--5, mno--6, 
//         // pqrs--7, tuv--8 wxyz--9, 0--0，
//         // 把密码中出现的小写字母都变成九键键盘对应的数字，如：a 变成 2，x 变成 9.
//         // 而密码中出现的大写字母则变成小写之后往后移一位，如：X ，先变成小写，再往后移一位，变成了 y ，例外：Z 往后移是 a 。
//         // 数字和其它的符号都不做变换。

//         // 输入一组密码，长度不超过100个字符。
//         // 输出密码变换后的字符串
//         var str = Console.ReadLine().ToCharArray();
//         foreach (var c in str)
//         {
//             //1--1， abc--2, def--3, ghi--4, jkl--5, mno--6, 
//             // pqrs--7, tuv--8 wxyz--9, 0--0，
//             if ("abc".Contains(c))
//             {
//                 Console.Write('2');
//             }
//             else if ("def".Contains(c))
//             {
//                 Console.Write('3');
//             }
//             else if ("ghi".Contains(c))
//             {
//                 Console.Write('4');
//             }
//             else if ("jkl".Contains(c))
//             {
//                 Console.Write('5');
//             }
//             else if ("mno".Contains(c))
//             {
//                 Console.Write('6');
//             }
//             else if ("pqrs".Contains(c))
//             {
//                 Console.Write('7');
//             }
//             else if ("tuv".Contains(c))
//             {
//                 Console.Write('8');
//             }
//             else if ("wxyz".Contains(c))
//             {
//                 Console.Write('9');
//             }
//             //大写字母则变成小写之后往后移一位，如：X ，先变成小写，再往后移一位，变成了 y ，例外：Z 往后移是 a 。
//             else if (c >= 'A' && c <= 'Z')
//             {
//                 if (c == 'Z')
//                 {
//                     Console.Write('a');
//                 }
//                 else
//                 {
//                     Console.Write((char)(c + 33));
//                 }
//             }
//             else
//             {
//                 Console.Write(c);
//             }

//         }
//     }
// }