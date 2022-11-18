namespace CodingExercises.InvertBinaryTree
{
    public class Exercise
    {
        /*
        Write a function that takes in a Binary Tree and inverts it. 
        In other words, the function should swap every left node in 
        the tree for its corresponding right node.

        Each BinaryTree node has an integer value, a left child node, 
        and a right child node. Children nodes can either be 
        BinaryTree nodes themselves or None / null.
        */


        public static void InvertBinaryTree(BinaryTree tree)
        {
            // record the right and left sides before modification.
            var rightTree = tree.right;
            var leftTree = tree.left;

            // get a handle to the root and cut off it's nodes.
            var root = tree;
            root.left = null;
            root.right = null;

            if (rightTree != null)
            {
                InvertBinaryTree(rightTree);
                root.left = rightTree;
            }
            if (leftTree != null)
            {
                InvertBinaryTree(leftTree);
                root.right = leftTree;
            }
        }

        public static void InvertBinaryTreeBruteForce(BinaryTree tree)
        {
            var items = ConvertTreeToOrderedList(tree);

            var treeInverted = ConvertListToInvertedTree(items);

            tree = treeInverted;
        }


        private static List<int> ConvertTreeToOrderedList(BinaryTree tree)
        {
            var items = new List<int>();

            if (tree.left != null)
            {
                items.AddRange(ConvertTreeToOrderedList(tree.left));
            }

            items.Add(tree.value);

            if (tree.right != null)
            {
                items.AddRange(ConvertTreeToOrderedList(tree.right));
            }

            return items;
        }

        private static BinaryTree ConvertListToInvertedTree(List<int> items)
        {
            throw new NotImplementedException();
        }
    }
}