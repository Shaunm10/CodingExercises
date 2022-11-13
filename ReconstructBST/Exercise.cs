namespace CodingExercises.ReconstructBST;

public class Exercise
{

    /*
    
    The pre-order traversal of a Binary Tree is a traversal technique 
    that starts at the tree's root node and visits nodes 
    in the following order:

    Current node    
    Left subtree
    Right subtree
    Given a non-empty array of integers representing the pre-order 
    traversal of a Binary Search Tree (BST), write a function 
    that creates the relevant BST and returns its root node.

    The input array will contain the values of BST nodes in 
    the order in which these nodes would be visited 
    with a pre-order traversal.

    Each BST node has an integer value, a left child node, 
    and a right child node. A node is said to be a valid 
    BST node if and only if it satisfies the BST property: 
    its value is strictly greater than the values of every 
    node to its left; its value is less than or equal to 
    the values of every node to its right; and its children 
    nodes are either valid BST nodes themselves or None / null.

    */
    public BST? ReconstructBst(List<int> preOrderTraversalValues)
    {
        var bst = new BST();
        var listCount = preOrderTraversalValues.Count;

        if (listCount > 0)
        {
            //Current node    
            var currentValue = preOrderTraversalValues[0];
            bst.value = currentValue;

            if (listCount > 1)
            {
                var nextValue = preOrderTraversalValues[1];

                if (nextValue <= currentValue)
                {
                    var indexOfNextLargest = preOrderTraversalValues.FindIndex(x => x > currentValue);
                    var leftListToProcess = preOrderTraversalValues.GetRange(1, indexOfNextLargest - 1);

                    // the number of items to take going right.
                    var numberOfItemsGoingRight = listCount - indexOfNextLargest;
                    var rightListToProcess = preOrderTraversalValues.GetRange(indexOfNextLargest, numberOfItemsGoingRight);

                    // go left

                    bst.left = ReconstructBst(leftListToProcess);
                    bst.right = ReconstructBst(rightListToProcess);

                }
                else
                {
                    // only if the next value is less than it's parent.
                    //Right subtree
                    bst.right = ReconstructBst(preOrderTraversalValues.GetRange(1, listCount - 1));

                }
            }
        }


        return bst;
    }
}
