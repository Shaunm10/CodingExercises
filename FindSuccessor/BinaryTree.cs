namespace CodingExercises.FindSuccessor
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree? left = null;
        public BinaryTree? right = null;
        public BinaryTree? parent = null;

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