// using System.Collections.Generic;
// using System.Linq;

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
//     // 一棵圣诞树记作根节点为 root 的二叉树，
//     // 节点值为该位置装饰彩灯的颜色编号。
//     // 请按照从左到右的顺序返回每一层彩灯编号，每一层的结果记录于一行。
//     public IList<IList<int>> DecorateRecord(TreeNode root)
//     {

//         if (root == null)
//             return new List<IList<int>>();
//         List<TreeNode> currentNodeList = new List<TreeNode>();
//         currentNodeList.Add(root);
//         List<IList<int>> res = new List<IList<int>>();
//         List<TreeNode> nextNodeList = new List<TreeNode>();
//         while (true)
//         {
//             foreach (var node in currentNodeList)
//             {
//                 if (node.left != null)
//                     nextNodeList.Add(node.left);
//                 if (node.right != null)
//                     nextNodeList.Add(node.right);
//             }
//             res.Add(currentNodeList.Select(x => x.val).ToList());
//             if (nextNodeList.Count == 0)
//                 break;
//             currentNodeList = nextNodeList;
//             nextNodeList = new List<TreeNode>();
//         }
//         return res.ToArray();

//     }
// }