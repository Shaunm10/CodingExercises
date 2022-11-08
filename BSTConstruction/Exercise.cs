namespace CodingExercises.BSTConstruction;


/*
Write a BST class for a Binary Search Tree. The class should support:

Inserting values with the insert method.

Removing values with the remove method  ; this method should only remove the first 
instance of a given value.

Searching for values with the contains method.
Note that you can't remove values from a single-node tree. In other words, 
calling the remove method on a single-node tree should simply not do anything.

Each BST node has an integer value, a left child node, and a right child node. 
A node is said to be a valid BST node if and only if it satisfies the 
BST property: its value is strictly greater than the values of every 
node to its left; its value is less than or equal to the values of 
every node to its right; and its children nodes are either valid 
BST nodes themselves or None / null.

*/

public class BST
{
    public int value;
    public BST? left;
    public BST? right;

    public BST(int value)
    {
        this.value = value;
    }

    public BST Insert(int value)
    {
        // if this node's value is greater than the incoming value
        if (this.value > value)
        {
            // send it left.
            if (this.left == null)
            {
                this.left = new BST(value);
            }
            else
            {
                this.left.Insert(value);
            }

        }
        else
        {
            // send it right.
            if (this.right == null)
            {
                this.right = new BST(value);
            }
            else
            {
                this.right.Insert(value);
            }

        }
        return this;
    }

    public bool Contains(int value)
    {
        if (this.value == value)
        {
            return true;
        }

        if (value > this.value)
        {
            // send right
            if (this.right == null)
            {
                return false;
            }
            return this.right.Contains(value);
        }
        else
        {
            // send left
            if (this.left == null)
            {
                return false;
            }
            return this.left.Contains(value);
        }
    }

    public BST Remove(int value)
    {
        // if the value being removed is larger than this node's value.
        if (this.value < value)
        {
            // go right
            if (this.right != null)
            {
                this.right = this.right.Remove(value);
            }
        }

        // if the value being removed is smaller than this node's value.
        if (this.value > value)
        {
            // go left
            if (this.left != null)
            {
                this.left = this.left.Remove(value);
            }
        }

        // if this is the value to be removed.
        if (this.value == value)
        {
            if (this.left == null && this.right == null) // 0 children
            {
                return null;
            }
            else if (this.left == null && this.right != null) // 1 child (right)
            {
                return this.right;
            }
            else if (this.right == null && this.left != null) // 1 child (left)
            {
                return this.left;
            }

            // 2 children
            var minValue = this.right.GetMinValue();
            this.value = minValue;
            this.right = this.right.Remove(minValue);
        }

        return this;
    }

    public int GetMinValue()
    {
        if (this.left != null)
        {
            return this.left.GetMinValue();
        }

        return this.value;
    }

}