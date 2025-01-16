// using System;

// public class Program
// {
//     public static void Main()
//     {
//         // 原理：ip地址的每段可以看成是一个0-255的整数，把每段拆分成一个二进制形式组合起来，然后把这个二进制数转变成
//         // 一个长整数。
//         // 举例：一个ip地址为10.0.3.193
//         // 每段数字             相对应的二进制数
//         // 10                   00001010
//         // 0                    00000000
//         // 3                    00000011
//         // 193                  11000001

//         // 组合起来即为：00001010 00000000 00000011 11000001,转换为10进制数就是：167773121，即该IP地址转换后的数字就是它了。
//         // 数据范围：保证输入的是合法的 IP 序列
//         string[] ips = Console.ReadLine().Split(".");
//         string binary = "";
//         for (int i = 0; i < ips.Length; i++)
//             binary += Convert.ToString(int.Parse(ips[i]), 2).PadLeft(8, '0');
//         Console.WriteLine(Convert.ToUInt32(binary, 2));
//         string ip = Console.ReadLine();
//         binary = Convert.ToString(uint.Parse(ip), 2).PadLeft(32, '0');
//         int[] result = new int[4];
//         for (int i = 0; i < 4; i++)
//             result[i] = Convert.ToInt32(binary.Substring(i * 8, 8), 2);
//         Console.WriteLine(string.Join(".", result));

//     }
// }