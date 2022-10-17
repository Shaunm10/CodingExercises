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
            result.Should().ContainInOrder(expectedOutput);
        }

          [Fact]
        public void Sample_Test2()
        {
            // arrange:
            var array = new int[] { -2, -1 };
            var expectedOutput = new int[] { 1, 4};

            // act:
            var result = Exercise.SortedSquaredArray(array);

            // assert:
            result.Should().NotBeNull();
            result.Should().ContainInOrder(expectedOutput);
        }

        [Fact]
        public void Sample_Test3()
        {
            // arrange:
            var array = new int[] { -3, -2, -1};
            var expectedOutput = new int[] { 1, 4, 9};

            // act:
            var result = Exercise.SortedSquaredArray(array);

            // assert:
            result.Should().NotBeNull();
            result.Should().ContainInOrder(expectedOutput);
        }
    
        [Fact]
        public void Sample_Test4()
        {
              // arrange:
            var array = new int[] { -5, -4, -3, -2, -1};
            var expectedOutput = new int[] { 1, 4, 9, 16, 25};

            // act:
            var result = Exercise.SortedSquaredArray(array);

            // assert:
            result.Should().NotBeNull();
            result.Should().ContainInOrder(expectedOutput);
        }

         [Fact]
        public void Sample_Test5()
        {
              // arrange:
            var array = new int[] { -2, -1};
            var expectedOutput = new int[] {1, 4};

            // act:
            var result = Exercise.SortedSquaredArray(array);

            // assert:
            result.Should().NotBeNull();
            result.Should().ContainInOrder(expectedOutput);
        }

         [Fact]
        public void Sample_Test6()
        {
              // arrange:
            var array = new int[] { -1, -1, 2, 3, 3, 3, 4};
            var expectedOutput = new int[] {1, 1, 4, 9, 9, 9, 16};

            // act:
            var result = Exercise.SortedSquaredArray(array);

            // assert:
            result.Should().NotBeNull();
            result.Should().ContainInOrder(expectedOutput);
        }
    }
}