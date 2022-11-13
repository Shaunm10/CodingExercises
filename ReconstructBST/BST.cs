namespace CodingExercises.ReconstructBST;

public class BST
{
    public int value;
    public BST? left = null;
    public BST? right = null;

    public BST(int value)
    {
        this.value = value;
    }

    public BST()
    {
        this.value = 0;
    }
}
