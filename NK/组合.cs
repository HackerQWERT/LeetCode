using System;
using System.Collections.Generic;

public class 组合
{
    // static void Main()
    // {
    //     Console.WriteLine("Hello World!");
    //     var s = new Solution();
    //     var result = s.Combine(4, 2);
    //     foreach (var item in result)
    //     {
    //         foreach (var i in item)
    //         {
    //             Console.Write(i + " ");
    //         }
    //         Console.WriteLine();
    //     }
    // }
    List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> Combine(int n, int k)
    {
        List<int> current = new List<int>();
        for (int i = 1; i <= n; i++)
            current.Add(i);
        DFS(current, 0, k, new List<int>());
        return result;
    }

    private void DFS(List<int> current, int index, int k, List<int> list)
    {
        if (k == 0)
        {
            result.Add(new List<int>(list));
            return;
        }
        for (int i = index; i < current.Count; i++)
        {

            var newList = new List<int>(list);
            newList.Add(current[i]);
            // List<int> next = new List<int>();
            // next.AddRange(current.GetRange(0, i));
            // next.AddRange(current.GetRange(i + 1, current.Count - (i + 1)));
            // List<int> next = current.GetRange(i + 1, current.Count - (i + 1));
            DFS(current, i + 1, k - 1, newList);
        }
    }
}