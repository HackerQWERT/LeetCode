// // using System.Globalization;

// // Solution solution = new Solution();
// // int[] nums = { 3, 2, 2, 3 };

// // System.Console.WriteLine(solution.RemoveElement(nums, 3));


// // public class Solution
// // {
// //     public int RemoveElement(int[] nums, int val)
// //     {
// //         int count = 0;
// //         for (int i = 0; i < nums.Length; i++)
// //         {
// //             if (nums[i] != val)
// //                 nums[count++] = nums[i];
// //         }
// //         return count
// //         ;
// //     }
// // }

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Button button = new Button();
//         button.Click += Button_Click;
//         button.OnClick();
//     }

//     private static void Button_Click(object sender, EventArgs e)
//     {
//         Console.WriteLine("Button clicked!");
//         Console.WriteLine("Sender: " + sender.ToString());
//     }
// }

// public class Button
// {
//     public event EventHandler Click;

//     public void OnClick()
//     {
//         if (Click != null)
//         {
//             Click(this, EventArgs.Empty);
//         }
//     }
// }

