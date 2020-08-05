namespace LeetCode
{
    public interface ITreeNodeService
    {
        // 1379. Find a Corresponding Node of a Binary Tree in a Clone of That Tree
        TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target);
    }
}