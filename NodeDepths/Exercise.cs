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
            var leftLevelSum = leftLevels.Sum(x => x);
            var rightLevelSum = rightLevels.Sum(x => x);

            // Write your code here.
            return leftLevelSum + rightLevelSum;
        }

        public static List<int> NodeDepths(BinaryTree? node, int currentNodeLevel)
        {
            var returnLevels = new List<int>();

            if (node == null)
            {
                return returnLevels;
            }

            if (node.left != null)
            {
                var leftLevels = NodeDepths(node.left, currentNodeLevel + 1);
                returnLevels.AddRange(leftLevels);
            }

            if (node.right != null)
            {
                var rightLevels = NodeDepths(node.right, currentNodeLevel + 1);
                returnLevels.AddRange(rightLevels);
            }

            // also add this nodes level
            returnLevels.Add(currentNodeLevel);

            return returnLevels;
        }
    }
}