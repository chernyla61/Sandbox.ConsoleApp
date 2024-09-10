using Sandbox.ConsoleApp;

namespace Sandbox.ConsoleApp.Test
{
    [TestFixture]
    public class BinaryTreeTest
    {

        [Test]
        public void TestSumOfLeftLeaves_SampleTree_ReturnsCorrectSum()
        {
            // Arrange: Creating a sample binary tree
            //        10
            //       /  \
            //      5    15
            //     / \     \
            //    3   7     20
            //       /
            //      2
            TreeNode root = new TreeNode(10);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(15);
            root.Right.Right = new TreeNode(20);
            root.Left.Left = new TreeNode(3);
            root.Left.Right = new TreeNode(7);
            root.Left.Right.Left = new TreeNode(2);

            BinaryTree tree = new BinaryTree(root);

            // Act: Call the method to test
            int sumOfLeftLeaves = tree.SumOfLeftLeaves(tree.Root);

            // Assert: Check that the sum is correct
            Assert.AreEqual(5, sumOfLeftLeaves);  // Left leaves are 2 and 3
        }

        [Test]
        public void TestSumOfLeftLeaves_NoLeftLeaves_ReturnsZero()
        {
            // Arrange: Creating a tree with no left leaves
            TreeNode root = new TreeNode(10);
            root.Right = new TreeNode(20);

            BinaryTree tree = new BinaryTree(root);

            // Act: Call the method to test
            int sumOfLeftLeaves = tree.SumOfLeftLeaves(tree.Root);

            // Assert: Check that the sum is zero
            Assert.AreEqual(0, sumOfLeftLeaves);
        }

        [Test]
        public void TestSumOfLeftLeaves_AllNodesAreLeftLeaves_ReturnsSumOfAllNodes()
        {
            // Arrange: Creating a tree where every node is a left leaf
            //   1
            //  /
            // 2
            //  /
            // 3
            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Left.Left = new TreeNode(3);

            BinaryTree tree = new BinaryTree(root);

            // Act: Call the method to test
            int sumOfLeftLeaves = tree.SumOfLeftLeaves(tree.Root);

            // Assert: Check that the sum is correct
            Assert.AreEqual(3, sumOfLeftLeaves);  // Only the left-most node (3) is a left leaf
        }
    }
}