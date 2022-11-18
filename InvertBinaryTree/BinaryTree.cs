namespace CodingExercises.InvertBinaryTree
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree? left;
        public BinaryTree? right;

        public BinaryTree(int value)
        {
            this.value = value;
        }

        public BinaryTree()
        {
            this.value = 0;
        }
    }
}