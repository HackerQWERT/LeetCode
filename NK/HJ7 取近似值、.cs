// using System;

// public class Program
// {
//     public static void Main()
//     {
//         // 写出一个程序，接受一个正浮点数值，输出该数值的近似整数值。如果小数点后数值大于等于 0.5 ,向上取整；小于 0.5 ，则向下取整。数据范围：保证输入的数字在 32 位浮点数范围内

//         string str = Console.ReadLine();
//         if (str == null)
//             return;
//         double num = double.Parse(str);
//         Console.WriteLine(Math.Round(num, MidpointRounding.AwayFromZero));
//     }
// }