// using System;

// public class Program
// {
//     public static void Main()
//     {

//         //将一个英文语句以单词为单位逆序排放。例如“I am a boy”，逆序排放后为“boy a am I”
//         //所有单词之间用一个空格隔开，语句中除了英文字母外，不再包含其他字符
//         string line = Console.ReadLine();
//         if (line == null)
//             return;
//         string[] words = line.Split(' ');
//         string[] words2 = new string[words.Length];
//         for (int i = 0; i < words.Length; i++)
//             words2[i] = words[words.Length - 1 - i];
//         Console.WriteLine(string.Join(" ", words2));
//     }
// }