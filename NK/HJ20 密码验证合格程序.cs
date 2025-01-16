// using System.Collections.Generic;
// using System.ComponentModel;
// using System.IO;

// public class Program
// {
//     public static void Main()
//     {
//         // 密码要求:
//         // 1.长度超过8位
//         // 2.包括：大写字母/小写字母/数字/其它符号，以上四种至少三种
//         // 3.不能分割出两个相等的长度大于 2 的子串，例如 abcabc 可以分割出两个 abc，不合法，ababa 则无法分割出2个aba。
//         // 注：其他符号不含空格或换行
//         //如果符合要求输出：OK，否则输出NG
//         string line;
//         while ((line = System.Console.ReadLine()) != null)
//         {
//             // 1.长度超过8位
//             if (line.Length <= 8)
//             {
//                 System.Console.WriteLine("NG");
//                 continue;
//             }
//             // 2.包括：大写字母/小写字母/数字/其它符号，以上四种至少三种
//             Dictionary<string, int> types = new Dictionary<string, int>();
//             types.Add("upper", 0);
//             types.Add("lower", 0);
//             types.Add("number", 0);
//             types.Add("other", 0);
//             foreach (char c in line)
//             {
//                 if (c >= 'A' && c <= 'Z')
//                 {
//                     types["upper"] = 1;
//                 }
//                 else if (c >= 'a' && c <= 'z')
//                 {
//                     types["lower"] = 1;
//                 }
//                 else if (c >= '0' && c <= '9')
//                 {
//                     types["number"] = 1;
//                 }
//                 else
//                 {
//                     types["other"] = 1;
//                 }
//             }
//             if (types["upper"] + types["lower"] + types["number"] + types["other"] < 3)
//             {
//                 System.Console.WriteLine("NG");
//                 continue;
//             }
//             // 3.不能分割出两个相等的长度大于 2 的子串，例如 abcabc 可以分割出两个 abc，不合法，ababa 则无法分割出2个aba。
//             for (int i = 0; i < line.Length - 5; i++)
//                 for (int j = i + 3; j < line.Length - 2; j++)
//                     if (line.Substring(i, 3) == line.Substring(j, 3))
//                     {
//                         System.Console.WriteLine("NG");
//                         goto End;
//                     }
//             System.Console.WriteLine("OK");
//         End:
//             continue;
//         }
//     }
// }