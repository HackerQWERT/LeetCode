// using System;
// using System.Collections.Generic;
// using System.ComponentModel;

// public class Program
// {
//     public static void Main()
//     {
//         // 读取输入的表达式
//         string expression = Console.ReadLine();
//         int result = EvaluateExpression(expression);
//         System.Console.WriteLine(result);

//     }

//     // 计算表达式的值
//     public static int EvaluateExpression(string expression)
//     {
//         Stack<int> numbers = new Stack<int>();
//         Stack<char> operators = new Stack<char>();
//         int i = 0;
//         while (i < expression.Length)
//         {
//             if (char.IsWhiteSpace(expression[i]))
//             {
//                 i++;
//                 continue;
//             }
//             if (char.IsDigit(expression[i]) || (expression[i] == '-' && (i == 0 || expression[i - 1] == '(' || IsOperator(expression[i - 1]))))
//             {
//                 int num = 0;
//                 int sign = 1;
//                 if (expression[i] == '-')
//                 {
//                     sign = -1;
//                     i++;
//                 }
//                 while (i < expression.Length && char.IsDigit(expression[i]))
//                 {
//                     num = num * 10 + expression[i] - '0';
//                     i++;
//                 }
//                 numbers.Push(num * sign);
//                 continue;
//             }

//             if (expression[i] == '(')
//             {
//                 operators.Push(expression[i]);
//             }
//             else if (expression[i] == ')')
//             {
//                 while (operators.Peek() != '(')
//                 {
//                     numbers.Push(ApplyOperation(operators.Pop(), numbers.Pop(), numbers.Pop()));
//                 }
//                 operators.Pop();
//             }
//             else if (IsOperator(expression[i]))
//             {
//                 while (operators.Count > 0 && GetPriority(expression[i]) <= GetPriority(operators.Peek()))
//                 {
//                     numbers.Push(ApplyOperation(operators.Pop(), numbers.Pop(), numbers.Pop()));
//                 }
//                 operators.Push(expression[i]);
//             }
//             i++;
//         }

//         while (operators.Count > 0)
//         {
//             numbers.Push(ApplyOperation(operators.Pop(), numbers.Pop(), numbers.Pop()));
//         }
//         return numbers.Pop();
//     }

//     //应用操作符进行计算
//     public static int ApplyOperation(char op, int b, int a)
//     {
//         switch (op)
//         {
//             case '+':
//                 return a + b;
//             case '-':
//                 return a - b;
//             case '*':
//                 return a * b;
//             case '/':
//                 if (b == 0)
//                 {
//                     throw new DivideByZeroException();
//                 }
//                 return a / b;
//         }
//         return 0;
//     }
//     // 判断字符是否为操作符
//     public static bool IsOperator(char c)
//     {
//         return c == '+' || c == '-' || c == '*' || c == '/';
//     }


//     //计算操作符优先级
//     public static int GetPriority(char op)
//     {
//         switch (op)
//         {
//             case '+':
//             case '-':
//                 return 1;
//             case '*':
//             case '/':
//                 return 2;
//             default:
//                 return 0;
//         }
//     }
// }