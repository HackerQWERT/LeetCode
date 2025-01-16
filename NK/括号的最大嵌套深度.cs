// using System.Collections;
// using System.Collections.Generic;

// public class Solution
// {
//     //给定 有效括号字符串 s，返回 s 的 嵌套深度。嵌套深度是嵌套括号的 最大 数量。
//     public int MaxDepth(string s)
//     {
//         Stack<char> stack = new Stack<char>();
//         int max = 0;
//         foreach (var c in s)
//         {
//             if (c == '(')
//             {
//                 stack.Push(c);
//                 max = stack.Count > max ? stack.Count : max;
//             }
//             else if (c == ')')
//             {
//                 stack.Pop();
//             }
//         }
//         return max;
//     }
// }