namespace CodingExercises.BranchSums
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree? left;
        public BinaryTree? right;

        public BinaryTree()
        {
            this.value = 0;
            this.left = null;
            this.right = null;
        }

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}