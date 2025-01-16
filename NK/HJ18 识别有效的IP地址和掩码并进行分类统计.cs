// using System;
// using System.Reflection.Metadata;
// using Microsoft.VisualBasic;

// public class Program
// {
//     public static void Main()
//     {
//         //请解析IP地址和对应的掩码，进行分类识别。要求按照A/B/C/D/E类地址归类，不合法的地址和掩码单独归类。
//         // 子网掩码为二进制下前面是连续的1，然后全是0。（例如：255.255.255.32就是一个非法的掩码）
//         // （注意二进制下全是1或者全是0均为非法子网掩码）
//         // 注意：
//         // 1. 类似于【0.*.*.*】和【127.*.*.*】的IP地址不属于上述输入的任意一类，也不属于不合法ip地址，计数时请忽略
//         // 2. 私有IP地址和A,B,C,D,E类地址是不冲突的
//         string line;
//         int a = 0, b = 0, c = 0, d = 0, e = 0, error = 0, p = 0;
//         while ((line = System.Console.ReadLine()) != null)
//         {
//             string[] tokens = line.Split('~');
//             string ip = tokens[0];  //IP地址
//             string mask = tokens[1];  //掩码
//             //判断是否错误IP地址或错误掩码
//             string[] ipTokens = ip.Split('.');
//             string[] maskTokens = mask.Split('.');
//             //1. 类似于【0.*.*.*】和【127.*.*.*】的IP地址不属于上述输入的任意一类，也不属于不合法ip地址，计数时请忽略
//             if (ipTokens[0] == "0" || ipTokens[0] == "127")
//                 continue;
//             //检查IP地址和掩码是否合法
//             bool isValidIP, isValidMask;
//             CheckValidIPOrMask(out isValidIP, out isValidMask, ipTokens, maskTokens);
//             if (!isValidMask || !isValidIP)
//             {
//                 error++;
//                 continue;
//             }
//             CheckIsABCDEOrPrivate(ref a, ref b, ref c, ref d, ref e, ref p, ipTokens);
//         }
//         System.Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e + " " + error + " " + p);
//     }
//     //检查IP地址是否属于ABCDE类和   私有IP地址
//     private static void CheckIsABCDEOrPrivate(ref int a, ref int b, ref int c, ref int d, ref int e, ref int p, string[] ipTokens)
//     {
//         // 所有的IP地址划分为 A,B,C,D,E五类
//         // A类地址从1.0.0.0到126.255.255.255;
//         // B类地址从128.0.0.0到191.255.255.255;
//         // C类地址从192.0.0.0到223.255.255.255;
//         // D类地址从224.0.0.0到239.255.255.255；
//         // E类地址从240.0.0.0到255.255.255.255
//         int first = int.Parse(ipTokens[0]);
//         int second = int.Parse(ipTokens[1]);
//         int third = int.Parse(ipTokens[2]);
//         int fourth = int.Parse(ipTokens[3]);
//         if (first >= 1 && first <= 126)
//             a++;
//         else if (first >= 128 && first <= 191)
//             b++;
//         else if (first >= 192 && first <= 223)
//             c++;
//         else if (first >= 224 && first <= 239)
//             d++;
//         else if (first >= 240 && first <= 255)
//             e++;
//         // 私有IP地址和A,B,C,D,E类地址是不冲突的
//         // 私网IP范围是：
//         // 从10.0.0.0到10.255.255.255
//         // 从172.16.0.0到172.31.255.255
//         // 从192.168.0.0到192.168.255.255
//         if (first == 10 || (first == 172 && second >= 16 && second <= 31) || (first == 192 && second == 168))
//             p++;
//     }

//     //检查IP地址和掩码是否合法
//     private static void CheckValidIPOrMask(out bool IsValidIP, out bool IsValidMask, string[] ipTokens, string[] maskTokens)
//     {
//         IsValidIP = true;
//         IsValidMask = true;
//         //检查 IP 地址是否由四个部分组成，每个部分之间用点（.）分隔。
//         if (ipTokens.Length != 4)
//         {
//             IsValidIP = false;
//             return;
//         }
//         // 检查每个部分是否都是数字。
//         int first = 0, second = 0, third = 0, fourth = 0;
//         if (!int.TryParse(ipTokens[0], out first) || !int.TryParse(ipTokens[1], out second) || !int.TryParse(ipTokens[2], out third) || !int.TryParse(ipTokens[3], out fourth))
//         {
//             IsValidIP = false;
//             return;
//         }
//         //检查每个部分的值是否在 0 到 255 之间
//         if (first < 0 || first > 255 || second < 0 || second > 255 || third < 0 || third > 255 || fourth < 0 || fourth > 255)
//         {
//             IsValidIP = false;
//             return;
//         }
//         //
//         //子网掩码必须是四个部分组成，每个部分之间用点（.）分隔。
//         if (maskTokens.Length != 4)
//         {
//             IsValidMask = false;
//             return;
//         }
//         // 每个部分必须是数字
//         int firstMask = 0, secondMask = 0, thirdMask = 0, fourthMask = 0;
//         if (!int.TryParse(maskTokens[0], out firstMask) || !int.TryParse(maskTokens[1], out secondMask) || !int.TryParse(maskTokens[2], out thirdMask) || !int.TryParse(maskTokens[3], out fourthMask))
//         {
//             IsValidMask = false;
//             return;
//         }
//         //且值在 0 到 255 之间。
//         if (firstMask < 0 || firstMask > 255 || secondMask < 0 || secondMask > 255 || thirdMask < 0 || thirdMask > 255 || fourthMask < 0 || fourthMask > 255)
//         {
//             IsValidMask = false;
//             return;
//         }
//         // 子网掩码的二进制表示必须是前面连续的 1，后面连续的 0。
//         string maskBinary = Convert.ToString(firstMask, 2).PadLeft(8, '0') +
//                             Convert.ToString(secondMask, 2).PadLeft(8, '0') +
//                             Convert.ToString(thirdMask, 2).PadLeft(8, '0') +
//                             Convert.ToString(fourthMask, 2).PadLeft(8, '0');
//         if (maskBinary.IndexOf("0") < maskBinary.LastIndexOf("1"))
//         {
//             IsValidMask = false;
//             return;
//         }
//     }


// }
