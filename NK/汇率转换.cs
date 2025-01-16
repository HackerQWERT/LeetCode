// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// public class Program
// {
//     public static void Main()
//     {

//         //汇率转换
//         int n = int.Parse(Console.ReadLine());
//         if (n == 0)
//             return;
//         Dictionary<string, double> dict = new Dictionary<string, double>();
//         //100CBY=1825JPY=123HKD=14EUR=12GBP
//         //1CNY=100fen
//         //1HKD=100cents
//         //1JPY=100sen
//         //1EUR=100eurocents
//         //1GBP=100pence
//         //全转换为对应fen的汇率
//         dict.Add("CNY", 100.0);
//         dict.Add("JPY", 10000 / 1825.0);
//         dict.Add("HKD", 10000 / 123.0);
//         dict.Add("EUR", 10000 / 14.0);
//         dict.Add("GBP", 10000 / 12.0);
//         dict.Add("fen", 1.0);
//         dict.Add("cents", 10000 / 123.0 / 100.0);
//         dict.Add("sen", 10000 / 1825.0 / 100.0);
//         dict.Add("eurocents", 10000 / 14.0 / 100.0);
//         dict.Add("pence", 10000 / 12.0 / 100.0);
//         //读取n行数据
//         //处理输入
//         // 20CNY53fen
//         // 53HKD87cents
//         //结果为 20*100+53*1+53*10000 / 123.0+87*1
//         double sum = 0;
//         StringBuilder stringBuilder = new StringBuilder();
//         for (int i = 0; i < n; i++)
//             stringBuilder.Append(Console.ReadLine());

//         string s = stringBuilder.ToString();

//         foreach (var d in dict)
//         {
//             if (s.Contains("CNY"))
//                 s = s.Replace("CNY", "*" + dict["CNY"] + "+");
//             if (s.Contains("JPY"))
//                 s = s.Replace("JPY", "*" + dict["JPY"] + "+");
//             if (s.Contains("HKD"))
//                 s = s.Replace("HKD", "*" + dict["HKD"] + "+");
//             if (s.Contains("EUR"))
//                 s = s.Replace("EUR", "*" + dict["EUR"] + "+");
//             if (s.Contains("GBP"))
//                 s = s.Replace("GBP", "*" + dict["GBP"] + "+");
//             if (s.Contains("fen"))
//                 s = s.Replace("fen", "*" + dict["fen"] + "+");
//             if (s.Contains("sen"))
//                 s = s.Replace("sen", "*" + dict["sen"] + "+");
//             if (s.Contains("eurocents"))
//                 s = s.Replace("eurocents", "*" + dict["eurocents"] + "+");
//             if (s.Contains("cents"))
//                 s = s.Replace("cents", "*" + dict["cents"] + "+");
//             if (s.Contains("pence"))
//                 s = s.Replace("pence", "*" + dict["pence"] + "+");

//         }
//         //去掉末尾的+
//         s = s.Remove(s.Length - 1);
//         // s = s.Substring(0, s.Length - 1);
//         //计算
//         sum = Eval(s);
//         Console.WriteLine(Math.Floor(sum));
//     }

//     private static double Eval(string s)
//     {
//         List<string> strings = s.Split('+').ToList();
//         double sum = 0;
//         foreach (var str in strings)
//         {
//             var nums = str.Split('*');

//             sum += double.Parse(nums[0]) * double.Parse(nums[1]);
//         }
//         return sum;
//     }
// }