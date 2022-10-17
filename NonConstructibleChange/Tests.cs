

namespace CodingExercises.NonConstructibleChange;

public class Tests
{
    [Fact]
    public void Sample_Test()
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
