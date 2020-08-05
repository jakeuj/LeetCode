using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Test
{
    public class TreeNodeServiceTest
    {
        private readonly ITreeNodeService _treeNodeService;

        public TreeNodeServiceTest()
        {
            _treeNodeService = new TreeNodeService();
        }
        //GetTargetCopy
        [Theory]
        [InlineData(3, 3)]
        public void GetTargetCopyTest(int treeNode, int expected)
        {
            var original = new TreeNode(7) { left = new TreeNode(4), right = new TreeNode(3) { left = new TreeNode(6), right = new TreeNode(19) } };            
            var cloned = new TreeNode(7) { left = new TreeNode(4), right = new TreeNode(3) { left = new TreeNode(6), right = new TreeNode(19) } };
            var result = _treeNodeService.GetTargetCopy(original, cloned, new TreeNode(treeNode));
            var actual = result.val;
            Assert.Equal(expected, actual);
        }
    }
}
