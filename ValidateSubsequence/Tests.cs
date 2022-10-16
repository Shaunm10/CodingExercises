using FluentAssertions;
using Xunit;


namespace CodingExercies.ValidateSubsequence
{
    public class Tests
    {
        [Fact]
        public void Returns_True_For_Sequence()
        {
            // arrange:
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 1, 6, -1, 10 };

            // act:
            var isValid = Exercise.IsValidSubsequence(array, sequence);

            // assert:
            Assert.True(isValid);
            //isValid.Should().BeTrue();
        }
    }
}