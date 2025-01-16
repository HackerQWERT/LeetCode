// using System;
// using System.Collections.Generic;

// class Solution
// {
//     /**
//      * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
//      *
//      * 
//      * @param number int整型 
//      * @return int整型
//      */
//     // public static void Main()
//     // {

//     //     Console.WriteLine(new Solution().jumpFloor(4));

//     // }
//     public int jumpFloor(int number)
//     {
//         int[] dp = new int[number + 1];
//         dp[0] = 1;
//         dp[1] = 1;
//         for (int i = 2; i <= number; i++)
//         {
//             dp[i] = dp[i - 1] + dp[i - 2];
//         }
//         return dp[number];
//     }
// }