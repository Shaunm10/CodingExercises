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
            isValid.Should().BeTrue();
        }

        [Fact]
        public void Returns_True_For_Sequence2()
        {
            // arrange:
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 5, 1, 22, 10 };

            // act:
            var isValid = Exercise.IsValidSubsequence(array, sequence);

            // assert:
            isValid.Should().BeTrue();
        }

        [Fact]
        public void Returns_True_For_AllOnes()
        {
            // arrange:
            var array = new List<int> { 1, 1, 1, 1, };
            var sequence = new List<int> { 1, 1, 1 };

            // act:
            var isValid = Exercise.IsValidSubsequence(array, sequence);

            // assert:
            isValid.Should().BeTrue();
        }

        [Fact]
        public void Returns_False_For_NonSequence()
        {
            // arrange:
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 1, -1, 6, 10 };

            // act:
            var isValid = Exercise.IsValidSubsequence(array, sequence);

            // assert:
            isValid.Should().BeFalse();
        }

        [Fact]
        public void Returns_False_For_NonSequence2()
        {
            // arrange:
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 1, 6, -1, -1 };

            // act:
            var isValid = Exercise.IsValidSubsequence(array, sequence);

            // assert:
            isValid.Should().BeFalse();
        }

        [Fact]
        public void Returns_False_For_NonSequence3()
        {
            // arrange:
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 26 };

            // act:
            var isValid = Exercise.IsValidSubsequence(array, sequence);

            // assert:
            isValid.Should().BeFalse();
        }
    }
}