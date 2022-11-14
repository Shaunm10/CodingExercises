namespace CodingExercises.ReconstructBST;

public class BST
{
    public int value { get; set; }
    public BST? left { get; set; } = null;
    public BST? right { get; set; } = null;

    public BST(int value)
    {
        this.value = value;
    }

    public BST()
    {
        this.value = 0;
    }
}
