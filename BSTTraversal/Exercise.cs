namespace CodingExercises.BSTTraversal
{
    public class Exercise
    {
        /*
        
        Write three functions that take in a Binary Search Tree (BST) and an empty array, 
        traverse the BST, add its nodes' values to the input array, and return that array. 
        The three functions should traverse the BST using the in-order, pre-order, 
        and post-order tree-traversal techniques, respectively.

        If you're unfamiliar with tree-traversal techniques, we recommend watching the 
        Conceptual Overview section of this question's video explanation before starting
        to code.

        Each BST node has an integer value, a left child node, 
        and a right child node. A node is said to be a valid BST node if and only if it 
        satisfies the BST property: its value is strictly greater than the values of every node 
        to its left; its value is less than or equal to the values of every node to its right; 
        and its children nodes are either valid BST nodes themselves or None / null.
        */


        /// <summary>
        ///  Get the values in order as traversing from left to right.
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static List<int> InOrderTraverse(BST tree, List<int> array)
        {
            // add the left(s)
            if (tree.left != null)
            {
                InOrderTraverse(tree.left, array);
            }

            // add this item
            array.Add(tree.value.GetValueOrDefault());

            // add the right side(s)
            if (tree.right != null)
            {
                InOrderTraverse(tree.right, array);
            }

            return array;
        }


        /// <summary>
        /// Get the values in order of the nodes top down.
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static List<int> PreOrderTraverse(BST tree, List<int> array)
        {
            // add this item
            array.Add(tree.value.GetValueOrDefault());

            // add the left(s)
            if (tree.left != null)
            {
                InOrderTraverse(tree.left, array);
            }

            // add the right side(s)
            if (tree.right != null)
            {
                InOrderTraverse(tree.right, array);
            }

            return array;
        }

        /// <summary>
        /// Get the values in order of the nodes top down.
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static List<int> PostOrderTraverse(BST tree, List<int> array)
        {
            // add the left(s)
            if (tree.left != null)
            {
                InOrderTraverse(tree.left, array);
            }

            // add the right side(s)
            if (tree.right != null)
            {
                InOrderTraverse(tree.right, array);
            }

            array.Add(tree.value.GetValueOrDefault());

            return array;
        }
    }
}