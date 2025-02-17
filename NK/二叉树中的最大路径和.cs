
// using System;

// public class 二叉树中的最大路径和
// {
//     private int max = int.MinValue;
//     public int MaxPathSum(TreeNode root)
//     {
//         DFS(root);
//         return max;
//     }
//     private int DFS(TreeNode root)
//     {
//         if (root == null)
//         {
//             return 0;
//         }
//         int leftMax = Math.Max(DFS(root.left), 0);
//         int rightMax = Math.Max(DFS(root.right), 0);
//         int currentMax = Math.Max(root.val + leftMax, root.val + rightMax);
//         max = Math.Max(max, root.val + leftMax + rightMax);
//         return currentMax;
//     }
// }