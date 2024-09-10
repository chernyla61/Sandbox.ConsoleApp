using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sandbox.ConsoleApp
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

    }
    public class BinaryTree
    {
        public TreeNode Root;
        public BinaryTree(TreeNode root)
        {
            Root = root;
        }

        /// <summary>
        /// Method to calculate the sum of all left leaf nodes
        /// A leaf node is a node with no children.
        /// A left leaf is a leaf node that is the left child of its parent.
        /// </summary>
        /// <param name="node">TreeNode</param>
        /// <returns>int</returns>

        public int SumOfLeftLeaves(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int sum = 0;

            // Check if the left node exists and is a leaf node
            if (node.Left != null && node.Left.Left == null && node.Left.Right == null)
            {
                sum += node.Left.Value;
            }

            // Recursively calculate for left and right subtrees
            sum += SumOfLeftLeaves(node.Left);
            sum += SumOfLeftLeaves(node.Right);

            return sum;
        }

    }
}
