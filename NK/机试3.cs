// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         //字符串分割
//         // 3
//         // 12abc-abCABc-4aB@
//         int k = int.Parse(Console.ReadLine());
//         var tokens = Console.ReadLine().Split('-');
//         //将除了第一个后面所有的拼接到一起
//         string s = string.Join("", tokens.Skip(1));

//         //第一个不做转换
//         List<string> stringList = new List<string>();
//         var first = tokens[0];
//         stringList.Add(first);
//         //后续的str根据K个一组切分
//         for (int i = 0; i < s.Length; i += k)
//         {
//             if (i + k > s.Length)
//             {
//                 stringList.Add(s.Substring(i));
//             }
//             else
//             {
//                 stringList.Add(s.Substring(i, k));
//             }
//         }
//         //除了第一个子窜,如果大写字母多，就全转为大写字母，如果小写字母多，就全转为小写字母，如果大小写字母数量相同，就保持原样
//         for (int i = 1; i < stringList.Count; i++)
//         {
//             var str = stringList[i];
//             int upperCount = 0;
//             int lowerCount = 0;
//             foreach (var c in str)
//                 if (char.IsUpper(c))
//                     upperCount++;
//                 else if (char.IsLower(c))
//                     lowerCount++;
//             if (upperCount > lowerCount)
//                 stringList[i] = str.ToUpper();
//             else if (upperCount < lowerCount)
//                 stringList[i] = str.ToLower();
//         }
//         //用-连接
//         Console.WriteLine(string.Join("-", stringList));









//     }
// }