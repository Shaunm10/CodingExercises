namespace CodingExercises.FindClosestValueInBST
{
    public class Exercise
    {
        /*
        
        Write a function that takes in a Binary Search Tree (BST) and a target integer value and returns the closest value to that target 
        value contained in the BST.

        You can assume that there will only be one closest value.

        Each BST node has an integer value, a left child node, and a right child node. 
        A node is said to be a valid BST node if and only if it satisfies the BST property: 
        its value is strictly greater than the values of every node to its left; its value is less than or equal to the values of 
        every node to its right; and its children nodes are either valid BST nodes themselves or None / null.

        */

        /// <summary>
        /// Brute Force Approach
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int FindClosestValueInBst(BST tree, int target)
        {

            int? leftValue = null;
            int? rightValue = null;
            var nodeValue = tree.value;
            if (tree.left != null)
            {

                leftValue = FindClosestValueInBst(tree.left, target);
            }
            if (tree.right != null)
            {

                rightValue = FindClosestValueInBst(tree.right, target);
            }

            var nodeDifference = Math.Abs(tree.value - target);
            var leftDifference = Math.Abs((leftValue ?? Int32.MaxValue) - target);
            var rightDifference = Math.Abs((rightValue ?? Int32.MaxValue) - target);

            // check for rightValue.
            if (
                rightDifference < nodeDifference &&
                rightDifference < leftDifference)
            {
                return rightValue.GetValueOrDefault();
            }

            // check for leftValue.
            if (
                leftDifference < nodeDifference &&
                leftDifference < rightDifference)
            {
                return leftValue.GetValueOrDefault();
            }

            return nodeValue;
        }


        public static int FindClosestValueInBstNonBF(BST tree, int target)
        {
            return -1;
        }



    }
}