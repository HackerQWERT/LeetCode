// using System;
// using System.Collections.Generic;

// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }
// public class 路径总和III
// {
//     Dictionary<long, int> prefixSumCount = new Dictionary<long, int>();
//     int targetSum;
//     int result = 0;
//     public int PathSum(TreeNode root, int targetSum)
//     {
//         if (root == null)
//             return 0;
//         this.targetSum = targetSum;
//         prefixSumCount.Add(0, 1);
//         DFS(root, 0);
//         return result;
//     }

//     private void DFS(TreeNode root, long sum)
//     {
//         long currentSum = sum + root.val;
//         if (prefixSumCount.ContainsKey(currentSum - targetSum))
//             result += prefixSumCount[currentSum - targetSum];
//         if (prefixSumCount.ContainsKey(currentSum))
//             prefixSumCount[currentSum]++;
//         else
//             prefixSumCount.Add(currentSum, 1);

//         if (root.left != null)
//             DFS(root.left, currentSum);
//         if (root.right != null)
//             DFS(root.right, currentSum);
//         prefixSumCount[currentSum]--;
//     }
// }
