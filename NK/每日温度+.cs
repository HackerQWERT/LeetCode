using System;
using System.Collections.Generic;
using System.Linq;

public class 每日温度
{
    // static void Main(string[] args)
    // {
    //     Solution solution = new Solution();
    //     int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
    //     int[] result = solution.DailyTemperatures(temperatures);
    //     foreach (var item in result)
    //     {
    //         Console.WriteLine(item);
    //     }
    // }
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        // Dictionary<int, int> dict = new Dictionary<int, int>();
        // 使用 ValueTuple 创建一个命名的元组
        Stack<(int index, int value)> stack = new Stack<(int index, int value)>();
        for (int i = temperatures.Length - 1; i >= 0; i--)
        {
            (int index, int value) temperature = (i, temperatures[i]);
            while (stack.Count > 0 && stack.Peek().value < temperature.value)
            {
                var t = stack.Pop();
                result[t.index] = temperature.index - t.index;
            }
            stack.Push(temperature);
        }
        while (stack.Count > 0)
        {
            var item = stack.Pop();
            result[item.index] = 0;
        }
        // for (int i = 0; i < temperatures.Length; i++)
        // {
        //     result[i] = result[i];
        // }
        return result;
    }
}