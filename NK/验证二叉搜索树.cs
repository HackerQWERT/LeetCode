using System;

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

public class 验证二叉搜索树
{
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        return DFS(root, Int64.MinValue, Int64.MaxValue);

    }

    private bool DFS(TreeNode root, long min, long max)
    {
        if (root == null)
        {
            return true;
        }
        if (root.val <= min || root.val >= max)
        {
            return false;
        }
        return DFS(root.left, min, root.val) && DFS(root.right, root.val, max);
    }

}
