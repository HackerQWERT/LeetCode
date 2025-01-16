// using System;
// public class Program
// {
//     public static void Main()
//     {
//         // 对输入的字符串进行加解密，并输出。
//         // 加密方法为：
//         // 当内容是英文字母时则用该英文字母的后一个字母替换，同时字母变换大小写,如字母a时则替换为B；字母Z时则替换为a；
//         // 当内容是数字时则把该数字加1，如0替换1，1替换2，9替换0；
//         // 其他字符不做变化。
//         // 解密方法为加密的逆过程。

//         // 输入描述：
//         // 第一行输入一串要加密的密码
//         // 第二行输入一串加过密的密码

//         // 输出描述：
//         // 第一行输出加密后的字符
//         // 第二行输出解密后的字符
//         string line1 = System.Console.ReadLine();
//         string line2 = System.Console.ReadLine();
//         //加密
//         System.Console.WriteLine(Encrypt(line1));
//         System.Console.WriteLine(Decrypt(line2));


//     }

//     private static char[] Decrypt(string line2)
//     {
//         char[] chars = line2.ToCharArray();
//         char[] result = new char[chars.Length];
//         for (int i = 0; i < chars.Length; i++)
//         {
//             if (char.IsLetter(chars[i]))
//             {
//                 if (char.IsLower(chars[i]))
//                 {
//                     if (chars[i] == 'a')
//                         result[i] = 'Z';
//                     else
//                         result[i] = (char)(chars[i] - 1 - 32);
//                 }
//                 else if (char.IsUpper(chars[i]))
//                 {
//                     if (chars[i] == 'A')
//                         result[i] = 'z';
//                     else
//                         result[i] = (char)(chars[i] - 1 + 32);
//                 }
//             }
//             else if (char.IsDigit(chars[i]))
//             {
//                 if (chars[i] == '0')
//                     result[i] = '9';
//                 else
//                     result[i] = (char)(chars[i] - 1);
//             }
//             else
//             {
//                 result[i] = chars[i];
//             }
//         }
//         return result;

//     }

//     private static char[] Encrypt(string line1)
//     {
//         char[] line1Array = line1.ToCharArray();
//         char[] result = new char[line1Array.Length];
//         for (int i = 0; i < line1Array.Length; i++)
//         {
//             if (char.IsLetter(line1Array[i]))
//             {
//                 if (char.IsLower(line1Array[i]))
//                 {
//                     if (line1Array[i] == 'z')
//                         result[i] = 'A';
//                     else
//                         result[i] = (char)(line1Array[i] + 1 - 32);
//                 }
//                 else if (char.IsUpper(line1Array[i]))
//                 {
//                     if (line1Array[i] == 'Z')
//                         result[i] = 'a';
//                     else
//                         result[i] = (char)(line1Array[i] + 1 + 32);
//                 }
//             }
//             else if (char.IsDigit(line1Array[i]))
//             {
//                 if (line1Array[i] == '9')
//                     result[i] = '0';
//                 else
//                     result[i] = (char)(line1Array[i] + 1);
//             }
//             else
//             {
//                 result[i] = line1Array[i];
//             }
//         }
//         return result;
//     }
// }