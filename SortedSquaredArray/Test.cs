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
            var array = new int[] { 1, 2, 3, 4 };

            // act:
            var result = Exercise.SortedSquaredArray(array);

            // assert:
            result.Should().NotBeNull();

        }
    }
}