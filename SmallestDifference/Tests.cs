namespace CodingExercises.SmallestDifference
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var arrayOne = new int[] { -1, 5, 10, 20, 28, 3 };
            var arrayTwo = new int[] { 26, 134, 135, 15, 17 };
            var expectedResult = new int[] { 28, 26 };

            // act:
            var result = Exercise.SmallestDifference(arrayOne, arrayTwo);

            // assert:
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void TestB()
        {
            // arrange:
            var arrayOne = new int[] { -1, 5, 10, 20, 3 };
            var arrayTwo = new int[] { 26, 134, 135, 15, 17 };
            var expectedResult = new int[] { 20, 17 };

            // act:
            var result = Exercise.SmallestDifference(arrayOne, arrayTwo);

            // assert:
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void TestC()
        {
            // arrange:
            var arrayOne = new int[] { 10, 0, 20, 25 };
            var arrayTwo = new int[] { 1005, 1006, 1014, 1032, 1031 };
            var expectedResult = new int[] { 25, 1005 };

            // act:
            var result = Exercise.SmallestDifference(arrayOne, arrayTwo);

            // assert:
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void TestD()
        {
            // arrange:
            var arrayOne = new int[] { 10, 0, 20, 25, 2200 };
            var arrayTwo = new int[] { 1005, 1006, 1014, 1032, 1031 };
            var expectedResult = new int[] { 25, 1005 };

            // act:
            var result = Exercise.SmallestDifference(arrayOne, arrayTwo);

            // assert:
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact()]
        public void TestE()
        {
            // arrange:
            var arrayOne = new int[] { 10, 0, 20, 25, 2000 };
            var arrayTwo = new int[] { 1005, 1006, 1014, 1032, 1031 };
            var expectedResult = new int[] { 2000, 1032 };

            // act:
            var result = Exercise.SmallestDifference(arrayOne, arrayTwo);

            // assert:
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}