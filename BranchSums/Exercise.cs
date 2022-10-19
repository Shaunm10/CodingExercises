namespace CodingExercises.BranchSums
{
    public class Exercise
    {
        /*
        Write a function that takes in a Binary Tree and returns a list of its branch 
        sums ordered from leftmost branch sum to rightmost branch sum.

        A branch sum is the sum of all values in a Binary Tree branch. 
        A Binary Tree branch is a path of nodes in a tree that starts at the root node and ends at any leaf node.

        Each BinaryTree node has an integer value, a left child node, and a right child node. 
        Children nodes can either be BinaryTree nodes themselves or None / null.
        */
        public static List<int> BranchSums(BinaryTree root)
        {
            var returnList = new List<int>();

            // is this node a leaf?
            if (root.left == null && root.right == null)
            {
                return new List<int> { root.value };
            }


            if (root.left != null)
            {
                var leftList = BranchSums(root.left);
                returnList.AddRange(leftList.Select(x => x + root.value));
            }
            if (root.right != null)
            {
                var rightList = BranchSums(root.right);
                returnList.AddRange(rightList.Select(x => x + root.value));
            }

            return returnList;
        }
    }
}