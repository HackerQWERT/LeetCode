// using System;
// using System.Collections.Generic;


// class Solution
// {
//     //     给出一个仅包含字符'(',')','{','}','['和']',的字符串，判断给出的字符串是否是合法的括号序列
//     // 括号必须以正确的顺序关闭，"()"和"()[]{}"都是合法的括号序列，但"(]"和"([)]"不合法。



//     public bool isValid(string s)
//     {
//         Stack<char> stack = new Stack<char>();
//         foreach (var c in s)
//         {
//             if (stack.Count == 0 || c == '(' || c == '[' || c == '{')
//                 stack.Push(c);
//             else
//             if (c == ']')
//             {
//                 if (stack.Peek() == '[')
//                     stack.Pop();
//                 else
//                     return false;
//             }
//             else if (c == '}')
//             {
//                 if (stack.Peek() == '{')
//                     stack.Pop();
//                 else
//                     return false;
//             }
//             else if (c == ')')
//             {
//                 if (stack.Peek() == '(')
//                     stack.Pop();
//                 else
//                     return false;
//             }
//         }
//         return stack.Count == 0;
//     }

// }