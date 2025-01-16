// using System;

// public class Program
// {
//     // 输入一个单向链表，输出该链表中倒数第k个结点，链表的倒数第1个结点为链表的尾指针。

//     // 链表结点定义如下：
//     // struct ListNode
//     // {
//     //     int val;
//     //     ListNode* m_pNext;
//     // };
//     // 正常返回倒数第k个结点指针。
//     // 输出描述：
//     // 每一组，输出倒数第k个结点的值
//     public static void Main()
//     {
//         string n;
//         while ((n = Console.ReadLine()) != null)
//         {
//             int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//             int k = int.Parse(Console.ReadLine());
//             System.Console.WriteLine(ints[ints.Length - k]);
//         }

//     }
// }