// using System.Collections.Generic;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.InteropServices;

// public class Program
// {
//     // 给定一些同学的信息（名字，成绩）序列，请你将他们的信息按照成绩从高到低或从低到高的排列,相同成绩

//     // 都按先录入排列在前的规则处理
//     // public static void Main()
//     // {
//     //     int n = int.Parse(System.Console.ReadLine());
//     //     List<List<object>> list = new List<List<object>>();
//     //     int flag = int.Parse(System.Console.ReadLine());

//     //     for (int i = 0; i < n; i++)
//     //     {
//     //         string[] s = System.Console.ReadLine().Split(' ');
//     //         List<object> l = new List<object>();
//     //         l.Add(s[0]);
//     //         l.Add(int.Parse(s[1]));
//     //         list.Add(l);
//     //     }
//     //     if (flag == 0)
//     //         list = list.OrderByDescending(x => x[1]).ToList();
//     //     else
//     //         list = list.OrderBy(x => x[1]).ToList();
//     //     foreach (var item in list)
//     //         System.Console.WriteLine(item[0] + " " + item[1]);

//     // }

//     public static void Main()
//     {
//         int n = int.Parse(System.Console.ReadLine());
//         int flag = int.Parse(System.Console.ReadLine());
//         List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
//         // Dictionary<string, int> dic = new Dictionary<string, int>();
//         for (int i = 0; i < n; i++)
//         {
//             string[] s = System.Console.ReadLine().Split(' ');
//             // dic.Add(s[0], int.Parse(s[1]));
//             list.Add(new KeyValuePair<string, int>(s[0], int.Parse(s[1])));
//         }
//         if (flag == 0)
//             list = list.OrderByDescending(x => x.Value).ToList();
//         else
//             list = list.OrderBy(x => x.Value).ToList();

//         // dic = dic.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
//         foreach (var item in list)
//             System.Console.WriteLine(item.Key + " " + item.Value);
//     }

// }