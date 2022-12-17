namespace CodingExercises.FindSuccessor;

public class Exercise
{
    /*
    Write a function that takes in a Binary Tree (where nodes have 
    an additional pointer to their parent node) as well as a 
    node contained in that tree and returns the given node's successor.

    A node's successor is the next node to be visited (immediately after 
    the given node) when traversing its tree using the in-order 
    tree-traversal technique. A node has no successor if it's the 
    last node to be visited in the in-order traversal.

    If a node has no successor, your function should return None / null.

    Each BinaryTree node has an integer value, a parent node, 
    a left child node, and a right child node. Children nodes 
    can either be BinaryTree nodes themselves or None / null.
    */
    public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node, bool initialSearch = true)
    {
        // go left
        if (!initialSearch && node.left != null)
        {
            return FindSuccessor(tree, node.left, false);
        }

        // this
        if (!initialSearch)
        {
            return node;
        }

        // go right
        if (node.right != null)
        {
            return FindSuccessor(tree, node.right, false);
        }

        // up
        return FindSuccessor(tree, node.parent, false);
    }



    public FindSuccessorInfo FindSuccessor(BinaryTree tree, BinaryTree node, FindSuccessorInfo findSuccessorInfo)
    {
        // if the successor is already found
        if (findSuccessorInfo.Successor != null)
        {
            // just return the info object.
            return findSuccessorInfo;
        }

        if (findSuccessorInfo.TargetValueFound)
        {
            // than this is the successor
            findSuccessorInfo.Successor = tree;
        }

        // left
        if (tree.left != null)
        {
            findSuccessorInfo = FindSuccessor(tree.left, node, findSuccessorInfo);
        }

        // self

        // if this is the value we are looking for
        if (tree.value == node.value)
        {
            // record it so we know the next value is the successor.
            findSuccessorInfo.TargetValueFound = true;
        }


        // right


        return findSuccessorInfo;
    }
}

public class FindSuccessorInfo
{
    public bool TargetValueFound { get; set; }
    public BinaryTree Successor { get; set; }

    public FindSuccessorInfo()
    {
        this.TargetValueFound = false;
        this.Successor = null;
    }
}
