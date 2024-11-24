// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         //开发一个坐标计算工具， A表示向左移动，D表示向右移动，W表示向上移动，S表示向下移动。从（0,0）点开始移动，从输入字符串里面读取一些坐标，并将最终输入结果输出到输出文件里面。
//         // 输入：
//         // 合法坐标为A(或者D或者W或者S) + 数字（两位以内）
//         // 坐标之间以;分隔。
//         // 非法坐标点需要进行丢弃。如AA10;  A1A;  $%$;  YAD; 等。
//         string line = System.Console.ReadLine();
//         string[] moves = line.Split(';');
//         // var validMoves = moves.Where(m => System.Text.RegularExpressions.Regex.IsMatch(m, @"^[ADWS]\d{1,2}$"));

//         //过滤有效的坐标 A(或者D或者W或者S) + 数字（两位以内）
//         //先判断第一个是不是AWSD，然后判断后面是不是一位或两位数字
//         var validMoves = moves.Where(m =>
//         {
//             if (m.Length != 2 && m.Length != 3)
//                 return false;
//             if (m[0] != 'A' && m[0] != 'D' && m[0] != 'W' && m[0] != 'S')
//                 return false;
//             if (m.Length == 2 && (m[1] < '0' || m[1] > '9'))
//                 return false;
//             if (m.Length == 3 && (m[1] < '0' || m[1] > '9' || m[2] < '0' || m[2] > '9'))
//                 return false;
//             return true;
//         });
//         Dictionary<char, int> dict = new Dictionary<char, int>
//         {
//             { 'A', 0 },
//             { 'D', 0 },
//             { 'W', 0 },
//             { 'S', 0 }
//         };
//         foreach (var move in validMoves)
//         {
//             dict[move[0]] += int.Parse(move.Substring(1));
//         }
//         System.Console.WriteLine($"{dict['D'] - dict['A']},{dict['W'] - dict['S']}");



//     }
// }