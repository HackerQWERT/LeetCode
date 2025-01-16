
// using System;
// using System.Collections.Generic;

// // public class TreeNode
// // {
// //     public int val;
// //     public TreeNode left;
// //     public TreeNode right;
// //     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
// //     {
// //         this.val = val;
// //         this.left = left;
// //         this.right = right;
// //     }
// // }
// public class Solution
// {
//     public IList<int> InorderTraversal(TreeNode root)
//     {
//         //递归
//         List<int> res = new List<int>();
//         Inorder(root, res);
//         return res;

//     }

//     private void Inorder(TreeNode root, List<int> res)
//     {
//         if (root == null)
//             return;
//         Inorder(root.left, res);
//         res.Add(root.val);
//         Inorder(root.right, res);
//     }
// }