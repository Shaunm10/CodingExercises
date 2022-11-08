namespace CodingExercises.ValidateBST;

public class Exercise
{
    /*
    Write a function that takes in a potentially invalid Binary Search Tree 
    (BST) and returns a boolean representing whether the BST is valid.

    Each BST node has an integer value, a left child node, and a 
    right child node. A node is said to be a valid BST node if and only if it 
    satisfies the BST property: its value is strictly greater than the values 
    of every node to its left; its value is less than or equal to the values 
    of every node to its right; and its children nodes are either valid BST 
    nodes themselves or None / null.

    A BST is valid if and only if all of its nodes are valid BST nodes.
    */
    public static bool ValidateBst(BST tree)
    {
        var isValid = true;

        // Write your code here.
        if (tree.left != null)
        {
            if (tree.left.value > tree.value)
            {
                isValid = false;
            }

            if (!ValidateBst(tree.left))
            {
                isValid = false;
            }

        }

        if (tree.right != null)
        {
            if (tree.right.value < tree.value)
            {
                isValid = false;
            }

            if (!ValidateBst(tree.right))
            {
                isValid = false;
            }

        }
        return isValid;
    }
}
