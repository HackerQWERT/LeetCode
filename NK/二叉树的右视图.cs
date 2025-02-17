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
// public class 二叉树的右视图
// {
//     private List<int> res = new List<int>();
//     public IList<int> RightSideView(TreeNode root)
//     {
//         if (root == null)
//             return res;
//         List<TreeNode> current = new List<TreeNode>() { root };
//         List<TreeNode> next = new List<TreeNode>();

//         while (true)
//         {
//             if (current.Count == 0)
//                 break;
//             res.Add(current[current.Count - 1].val);
//             foreach (var node in current)
//             {
//                 if (node.left != null)
//                     next.Add(node.left);
//                 if (node.right != null)
//                     next.Add(node.right);
//             }
//             var temp = current;
//             current = next;
//             next = temp;
//             next.Clear();
//         }
//         return res;
//     }

// }
