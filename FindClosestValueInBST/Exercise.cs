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
        public static int FindClosestValueInBstBruteForce(BST tree, int target)
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
            var leftDifference = Math.Abs((leftValue ?? 9999999) - target);
            var rightDifference = Math.Abs((rightValue ?? 9999999) - target);

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


        /// <summary>
        /// Systematic approach
        /// </summary>
        public static int FindClosestValueInBst(BST? tree, int target)
        {

            if (tree == null)
            {
                return 99999;
            }

            // is the current value closer to the target than the last?
            var currentDifference = Math.Abs(tree.value - target);

            if (currentDifference == 0)
            {
                return tree.value;
            }

            // if is is the current bigger or less than target
            var isTargetLarger = tree.value < target;

            if (isTargetLarger)
            {   // if smaller go right
                var closestValueRight = FindClosestValueInBst(tree.right, target);
                var rightDifference = Math.Abs(closestValueRight - target);

                if (rightDifference < currentDifference)
                {
                    return closestValueRight;
                }

            }
            else
            {
                // if bigger go left
                var closestValueLeft = FindClosestValueInBst(tree.left, target);
                var leftDifferences = Math.Abs(closestValueLeft - target);
                if (leftDifferences < currentDifference)
                {
                    return closestValueLeft;
                }
            }

            return tree.value;
        }
    }
}