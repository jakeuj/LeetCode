using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class TreeNodeService : ITreeNodeService
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            cloned.TryGet(target, out var output);
            return output;
        }
    }

    public static class MyExtensions
    {
        public static bool TryGet(this TreeNode node, TreeNode targetNode,out TreeNode treeNode)
        {
            treeNode = null;
            if (node == null)
                return false;
            else if (node.val == targetNode.val)
            {
                treeNode = node;
                return true;
            }
            else if (node.left.TryGet(targetNode, out treeNode))
            {
                return true;
            }
            else if (node.right.TryGet(targetNode, out treeNode))
            {
                return true;
            }
            else
                return false;
        }
    }
}
