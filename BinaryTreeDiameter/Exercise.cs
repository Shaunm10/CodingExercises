namespace CodingExercises.BinaryTreeDiameter
{
    public class Exercise
    {
        /*
        
        Write a function that takes in a Binary Tree and returns its diameter. 
        The diameter of a binary tree is defined as the length of its longest 
        path, even if that path doesn't pass through the root of the tree.

        A path is a collection of connected nodes in a tree, 
        where no node is connected to more than two other nodes. 
        The length of a path is the number of edges between 
        the path's first node and its last node.

        Each BinaryTree node has an integer value, a left 
        child node, and a right child node. Children nodes 
        can either be BinaryTree nodes themselves or None / null.
        */

        public int BinaryTreeDiameter(BinaryTree tree)
        {

            if (tree.left == null && tree.right == null)
            {
                return 1;
            }

            int? leftCount = null;
            int? rightCount = null;

            if (tree.left != null)
            {
                leftCount = BinaryTreeDiameter(tree.left) + 1;
            }

            if (tree.right != null)
            {
                rightCount = BinaryTreeDiameter(tree.right) + 1;
            }

            if (leftCount.HasValue && rightCount.HasValue)
            {
                return leftCount.Value + rightCount.Value;
            }

            return Math.Max(leftCount.GetValueOrDefault(), rightCount.GetValueOrDefault());
        }
    }
}