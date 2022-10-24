namespace CodingExercises.NthFibonacci;

public class Tests
{
    [Fact]
    public void TestA()
    {
        // arrange:
        var input = 2;
        var expectedOutput = 1;

        // act:
        var result = Exercise.GetNthFib(input);

        // assert:
        result.Should().Be(expectedOutput);
    }

    [Fact]
    public void TestB()
    {
        // arrange:
        var input = 6;
        var expectedOutput = 5;

        // act:
        var result = Exercise.GetNthFib(input);

        // assert:
        result.Should().Be(expectedOutput);
    }
}
