using System;
using System.Collections.Generic;
using System.Reflection;

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
public class 从前序与中序遍历序列构造二叉树
{
    private Dictionary<int, int> inorderIndex = new Dictionary<int, int>();
    // public static void Main()
    // {
    //     Console.WriteLine("Hello World!");
    //     Solution s = new Solution();
    //     int[] preorder = new int[] { 3, 9, 20, 15, 7 };
    //     int[] inorder = new int[] { 9, 3, 15, 20, 7 };
    //     TreeNode root = s.BuildTree(preorder, inorder);

    // }
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0)
            return null;
        for (int j = 0; j < inorder.Length; j++)
            inorderIndex[inorder[j]] = j;
        var preorderSpan = preorder.AsSpan();
        var inorderSpan = inorder.AsSpan();

        return BuildTree(preorderSpan, inorderSpan, 0);
    }
    private TreeNode BuildTree(Span<int> preorderSpan, Span<int> inorderSpan, int indexOffset)
    {
        if (preorderSpan.Length == 0)
            return null;
        TreeNode root = new TreeNode(preorderSpan[0]);
        int i = inorderIndex[preorderSpan[0]] - indexOffset;
        root.left = BuildTree(preorderSpan.Slice(1, i), inorderSpan.Slice(0, i), indexOffset);
        root.right = BuildTree(preorderSpan.Slice(i + 1), inorderSpan.Slice(i + 1), indexOffset + i + 1);
        return root;
    }
}