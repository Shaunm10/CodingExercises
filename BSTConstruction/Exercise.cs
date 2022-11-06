namespace CodingExercises.BSTConstruction
{
    public class Exercise
    {
        /*
        Write a BST class for a Binary Search Tree. The class should support:

        Inserting values with the insert method.

        Removing values with the remove method; this method should only remove the first 
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
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }

            public BST Insert(int value)
            {
                // Write your code here.
                // Do not edit the return statement of this method.
                return this;
            }

            public bool Contains(int value)
            {
                // Write your code here.
                return false;
            }

            public BST Remove(int value)
            {
                // Write your code here.
                // Do not edit the return statement of this method.
                return this;
            }

        }
    }