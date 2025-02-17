
// using System;

// public class 二叉搜索树中第K小的元素
// {
//     // static void Main(string[] args)
//     // {
//     //     TreeNode root = new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4));
//     //     Console.WriteLine(new Solution().KthSmallest(root, 1));
//     // }
//     private int count = 0;
//     private int target = 0;
//     private int res = 0;
//     public int KthSmallest(TreeNode root, int k)
//     {
//         if (root == null)
//             return 0;
//         target = k;
//         InOrder(root);
//         return res;

//     }
//     private void InOrder(TreeNode root)
//     {
//         if (root == null || count == target)
//             return;
//         if (root.left != null)
//             InOrder(root.left);
//         count++;
//         if (count == target)
//         {
//             res = root.val;
//             return;
//         }
//         if (root.right != null)
//             InOrder(root.right);
//     }
// }

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