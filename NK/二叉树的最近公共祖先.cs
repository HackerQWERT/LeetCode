// using System;
// using System.Collections.Generic;

// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int x) { val = x; }
// }
// public class 二叉树的最近公共祖先
// {
//     static void Main()
//     {
//         TreeNode root = new TreeNode(3);
//         root.left = new TreeNode(5);
//         root.right = new TreeNode(1);
//         root.left.left = new TreeNode(6);
//         root.left.right = new TreeNode(2);
//         root.right.left = new TreeNode(0);
//         root.right.right = new TreeNode(8);
//         root.left.right.left = new TreeNode(7);
//         root.left.right.right = new TreeNode(4);
//         TreeNode p = root.left;
//         TreeNode q = root.right;
//         Console.WriteLine(new Solution().LowestCommonAncestor(root, p, q).val);
//     }

//     private HashSet<TreeNode> qSet = new HashSet<TreeNode>();
//     bool pFound = false;
//     // private HashSet<TreeNode> pSet = new HashSet<TreeNode>();
//     private LinkedList<TreeNode> pList = new LinkedList<TreeNode>();
//     bool qFound = false;

//     public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
//     {
//         DFS(root, p, q);
//         // List<TreeNode> pList = new List<TreeNode>(pSet);
//         // for (int i = pList.Count - 1; i >= 0; i--)
//         // {
//         //     if (qSet.Contains(pList[i]))
//         //         return pList[i];
//         // }
//         for (var node = pList.Last; node != null; node = node.Previous)
//         {
//             if (qSet.Contains(node.Value))
//                 return node.Value;
//         }
//         return null;
//     }

//     private void DFS(TreeNode root, TreeNode p, TreeNode q)
//     {
//         if (root == null || (pFound && qFound))
//             return;
//         if (!pFound)
//             // pSet.Add(root);
//             pList.AddLast(root);
//         if (!qFound)
//             qSet.Add(root);
//         if (root == p)
//         {
//             pFound = true;
//         }
//         if (root == q)
//         {
//             qFound = true;
//         }
//         DFS(root.left, p, q);
//         DFS(root.right, p, q);
//         if (!pFound)
//             // pSet.emove(root);
//             pList.RemoveLast();
//         if (!qFound)
//             qSet.Remove(root);
//         return;
//     }
// }