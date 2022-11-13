namespace CodingExercises.ReconstructBST;

public class Tests
{

    [Fact]
    public void TestA()
    {
        // arrange:
        var input = new List<int> { 10, 4, 2, 1, 5, 17, 19, 18 };

        // act:
        var result = new Exercise().ReconstructBst(input);

        // assert:
        result.Should().NotBeNull();
    }
}
