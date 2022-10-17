using FluentAssertions;
using Xunit;

namespace CodingExercises.SortedSquaredArray
{
    public class Test
    {
        [Fact]
        public void Sample_Test()
        {
            // arrange:
            var array = new int[] { 1, 2, 3, 5, 6, 8, 9 };
            var expectedOutput = new int[] { 1, 4, 9, 25, 36, 64, 81 };

            // act:
            var result = Exercise.SortedSquaredArray(array);

            // assert:
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedOutput);
        }
    }
}