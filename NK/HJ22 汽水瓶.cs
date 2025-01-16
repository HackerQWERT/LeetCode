// public class Program
// {
//     public static void Main()
//     {
//         //某商店规定：三个空汽水瓶可以换一瓶汽水，允许向老板借空汽水瓶（但是必须要归还）。
//         // 小张手上有n个空汽水瓶，她想知道自己最多可以喝到多少瓶汽水。

//         // 输入文件最多包含 10 组测试数据，每个数据占一行，仅包含一个正整数 n（ 1<=n<=100 ）
//         // 表示小张手上的空汽水瓶数。n=0 表示输入结束，你的程序不应当处理这一行。
//         // 对于每组测试数据，输出一行，表示最多可以喝的汽水瓶数。如果一瓶也喝不到，输出0。
//         string line;
//         while ((line = System.Console.ReadLine()) != null)
//         {
//             int n = int.Parse(line);
//             if (n == 0)
//             {
//                 break;
//             }
//             int count = 0;
//             while (true)
//             {
//                 if (n == 1)
//                     break;
//                 if (n == 2)
//                 {
//                     count++;
//                     break;
//                 }
//                 count += n / 3;
//                 // n = n / 3 + n % 3;
//             }
//             System.Console.WriteLine(count);
//         }
//     }
// }
