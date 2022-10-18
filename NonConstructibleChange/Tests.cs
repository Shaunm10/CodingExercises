

namespace CodingExercises.NonConstructibleChange;

public class Tests
{

    [Fact]
    public void Sample_Test()
    {
        // arrange:
        var coins = new int[] { 1, 2, 5 };

        var expectedOutcome = 4;

        // act:
        var response = Exercise.NonConstructibleChange(coins);

        // assert:
        response.Should().Be(expectedOutcome);
    }

    [Fact(Skip = "Needs more work.")]
    public void Sample_Test2()
    {
        // arrange:
        var coins = new int[] { 5, 7, 1, 1, 2, 3, 22 };

        var expectedOutcome = 20;

        // act:
        var response = Exercise.NonConstructibleChange(coins);

        // assert:
        response.Should().Be(expectedOutcome);
    }

}
