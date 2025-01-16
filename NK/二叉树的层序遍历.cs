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
using System.Collections.Generic;

public class 二叉树的层序遍历
{

    List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
            return result;
        List<TreeNode> currentLevel = new List<TreeNode>() { root };
        List<TreeNode> nextLevel = new List<TreeNode>();
        while (true)
        {
            if (currentLevel.Count == 0)
                break;
            List<int> level = new List<int>();
            foreach (var node in currentLevel)
            {
                level.Add(node.val);
                if (node.left != null)
                    nextLevel.Add(node.left);
                if (node.right != null)
                    nextLevel.Add(node.right);
            }
            List<TreeNode> temp = currentLevel;
            currentLevel = nextLevel;
            nextLevel = temp;
            nextLevel.Clear();
            result.Add(level);

        }
        return result;
    }
}