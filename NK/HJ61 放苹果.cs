// public class Program
// {
//     // 把m个同样的苹果放在n个同样的盘子里，允许有的盘子空着不放，问共有多少种不同的分法？
//     // 注意：如果有7个苹果和3个盘子，（5，1，1）和（1，5，1）被视为是同一种分法。

//     public static void Main()
//     {
//         string line;
//         while ((line = System.Console.ReadLine()) != null)
//         { // 注意 while 处理多个 case
//             string[] tokens = line.Split();
//             System.Console.WriteLine(int.Parse(tokens[0]) + int.Parse(tokens[1]));
//         }
//     }
// }