namespace CodingExercises.NodeDepths
{
    public class Exercise
    {

        /*
        
        The distance between a node in a Binary Tree and the tree's root is 
        called the node's depth.

        Write a function that takes in a Binary Tree and returns the 
        sum of its nodes' depths.

        Each BinaryTree node has an integer value, 
        a left child node, and a right child node. 
        Children nodes can either be BinaryTree nodes themselves or None / null.
        */
        public static int NodeDepths(BinaryTree root)
        {
            if (root.left == null && root.right == null)
            {
                return 0;
            }

            var leftLevels = NodeDepths(root.left, 1);
            var rightLevels = NodeDepths(root.right, 1);


            // Write your code here.
            return -1;
        }

        public static List<int> NodeDepths(BinaryTree node, int currentNodeLevel)
        {

            var returnNodes = new List<int>();

            if (node == null)
            {
                return returnNodes;
            }

            // base case
            if (node.right == null && node.left == null)
            {
                returnNodes.Add(currentNodeLevel);
                return returnNodes;
            }

            if (node.left != null)
            {
                var leftLevels = NodeDepths(node.left, currentNodeLevel + 1);

                returnNodes.AddRange(leftLevels);
            }

            if (node.right != null)
            {
                var rightLevels = NodeDepths(node.right, currentNodeLevel + 1);
            }

            return returnNodes;
        }
    }
}