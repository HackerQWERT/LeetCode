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
// public class 二叉树展开为链表
// {
//     // static void Main(string[] args)
//     // {
//     //     TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(5, null, new TreeNode(6)));
//     //     new Solution().Flatten(root);
//     //     while (root != null)
//     //     {
//     //         Console.WriteLine(root.val);
//     //         root = root.right;
//     //     }
//     // }
//     private TreeNode current = new TreeNode();
//     public void Flatten(TreeNode root)
//     {
//         if (root == null)
//             return;
//         DFS(root);
//     }

//     private void DFS(TreeNode root)
//     {

//         TreeNode temp = root.right;
//         current.right = root;
//         current = root;

//         if (root.left != null)
//             DFS(root.left);
//         if (temp != null)
//             DFS(temp);
//         root.left = null;
//     }
// }