namespace CodingExercises.BinarySearch
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            var target = 33;
            var expectedOutput = 3;

            // act:
            var result = Exercise.BinarySearch(array, target);

            // assert:
            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void TestB()
        {
            // arrange:
            var array = new int[] { 1, 5, 23, 111 };
            var target = 5;
            var expectedOutput = 1;

            // act:
            var result = Exercise.BinarySearch(array, target);

            // assert:
            result.Should().Be(expectedOutput);
        }
        [Fact]
        public void TestC()
        {
            // arrange:
            var array = new int[] { 1, 5, 23, 111 };
            var target = 35;
            var expectedOutput = -1;

            // act:
            var result = Exercise.BinarySearch(array, target);

            // assert:
            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void TestD()
        {
            // arrange:
            var array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            var target = 0;
            var expectedOutput = 0;

            // act:
            var result = Exercise.BinarySearch(array, target);

            // assert:
            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void TestE()
        {
            // arrange:
            var array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            var target = 1;
            var expectedOutput = 1;

            // act:
            var result = Exercise.BinarySearch(array, target);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}