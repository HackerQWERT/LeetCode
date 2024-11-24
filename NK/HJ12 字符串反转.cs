// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // //接受一个只包含小写字母的字符串，然后输出该字符串反转后的字符串。（字符串长度不超过1000）
//         // string str = System.Console.ReadLine();
//         // if (str == null)
//         //     return;

//         // System.Console.WriteLine(str.Reverse().ToArray());


//         //给你一个数组，每个元素都是字符串类型的版本号，需要把版本号从小到大排序后返回。需要注意的是，“1.45”指的是第一代的第45版，所以“1.8”要比“1.45”小（这么说来13.11确实比13.8更大了）。
//         string[] strs = System.Console.ReadLine().Split(' ');
//         List<Version> list = new List<Version>();
//         foreach (var item in strs)
//         {
//             string[] temp = item.Split('.');
//             list.Add(new Version(item, int.Parse(temp[0]), int.Parse(temp[1])));
//         }
//         System.Console.WriteLine(string.Join(' ', list.OrderBy(x => x.Major).ThenBy(x => x.Minor).Select(x => x.versionNum)));
//     }
//     public record Version(string versionNum, int Major, int Minor);
// }