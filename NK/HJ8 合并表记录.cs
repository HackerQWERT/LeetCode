// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         //数据表记录包含表索引index和数值value（int范围的正整数），请对表索引相同的记录进行合并，即将相同索引的数值进行求和运算，输出按照index值升序进行输出。
//         int n = int.Parse(Console.ReadLine());
//         Dictionary<int, int> dict = new Dictionary<int, int>();
//         for (int i = 0; i < n; i++)
//         {
//             string str = Console.ReadLine();
//             int key = int.Parse(str.Split(' ')[0]);
//             int value = int.Parse(str.Split(' ')[1]);
//             dict[key] = dict.ContainsKey(key) ? dict[key] + value : value;
//         }
//         //按KEY从小到大顺序输出
//         // var sortKeys = new SortedSet<int>(dict.Keys);
//         var sortKeyList = dict.Keys.ToList();
//         sortKeyList.Sort();

//         foreach (var key in sortKeyList)
//         {
//             Console.WriteLine(key + " " + dict[key]);
//         }



//     }
// }