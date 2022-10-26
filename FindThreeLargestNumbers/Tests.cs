namespace CodingExercises.FindThreeLargestNumbers
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var array = new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, };
            var expectedOutput = new int[] { 18, 141, 541 };

            // act:
            var result = Exercise.FindThreeLargestNumbers(array);

            // assert:
            result.Should().ContainInOrder(expectedOutput);
        }

        [Fact]
        public void TestB()
        {
            // arrange:
            var array = new int[] { 10, 5, 9, 10, 12 };
            var expectedOutput = new int[] { 10, 10, 12 };

            // act:
            var result = Exercise.FindThreeLargestNumbers(array);

            // assert:
            result.Should().ContainInOrder(expectedOutput);
        }
    }
}