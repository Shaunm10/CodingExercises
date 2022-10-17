using FluentAssertions;
using Xunit;

namespace CodingExercises.TournamentWinner
{
    public class Test
    {
        [Fact]
        public void Sample_Test()
        {
            // arrange:
            var competitions = new List<List<string>>{
                new List<string>{"HTML","C#"},
                new List<string>{"C#","Python"},
                new List<string>{"Python","HTML"}
              };

            var results = new List<int> { 0, 0, 1 };
            var expectedOutcome = "Python";

            // act:
            var response = Exercise.TournamentWinner(competitions, results);

            // assert:
            response.Should().Be(expectedOutcome);
        }
    }
}