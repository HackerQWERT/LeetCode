// using System;

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
// public class Solution
// {
//     // 给你一个二叉树的根节点 root ，判断其是否是一个有效的二叉搜索树。

//     // 有效 二叉搜索树定义如下：
//     // 节点的左子树只包含 小于 当前节点的数。
//     // 节点的右子树只包含 大于 当前节点的数。
//     // 所有左子树和右子树自身必须也是二叉搜索树。
//     public bool IsValidBST(TreeNode root)
//     {
//         return IsValidBSTHelper(root, null, null);
//     }

//     private bool IsValidBSTHelper(TreeNode node, int? lowest, int? highest)
//     {
//         if (node == null)
//             return true;

//         if (lowest.HasValue && node.val <= lowest.Value)
//             return false;
//         if (highest.HasValue && node.val >= highest.Value)
//             return false;

//         return IsValidBSTHelper(node.left, lowest, node.val) && IsValidBSTHelper(node.right, node.val, highest);
//     }

// }