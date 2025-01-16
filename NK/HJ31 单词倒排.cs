// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // 对字符串中的所有单词进行倒排。
//         // 说明：
//         // 1、构成单词的字符只有26个大写或小写英文字母；
//         // 2、非构成单词的字符均视为单词间隔符；
//         // 3、要求倒排后的单词间隔符以一个空格表示；如果原字符串中相邻单词间有多个间隔符时，倒排转换后也只允许出现一个空格间隔符；
//         // 4、每个单词最长20个字母；
//         // 输出描述：
//         // 输出句子的倒排结果
//         char[] chars = System.Console.ReadLine().ToCharArray();
//         for (int i = 0; i < chars.Length; i++)
//             if (!char.IsLetter(chars[i]))
//                 chars[i] = ' ';
//         string str = new string(chars);HJ32 密码截取

//         var strings = str.Split().Reverse().ToArray();
//         System.Console.WriteLine(string.Join(" ", strings));
//     }
// }