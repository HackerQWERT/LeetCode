// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         string str = Console.ReadLine();
//         if (str == null)
//             return;
//         //请按长度为8拆分每个输入字符串并进行输出；
//         while (str.Length >= 8)
//         {
//             Console.WriteLine(str.Substring(0, 8));
//             str = str.Substring(8);
//         }
//         //长度不是8整数倍的字符串请在后面补数字0，空字符串不处理。
//         if (str.Length > 0)
//         {
//             str = str.PadRight(8, '0');
//             Console.WriteLine(str);
//         }


//     }
// }