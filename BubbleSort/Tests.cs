namespace CodingExercises.BubbleSort
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var inputArray = new int[] { 8, 5, 2, 9, 5, 6, 3 };
            var expectedOutput = new int[] { 2, 3, 5, 5, 6, 8, 9 };

            // act:
            var result = Exercise.BubbleSort(inputArray);

            // assert:
            result.Should().ContainInOrder(expectedOutput);
        }

        [Fact]
        public void TestB()
        {
            // arrange:
            var inputArray = new int[] { 1, 3, 2 };
            var expectedOutput = new int[] { 1, 2, 3 };

            // act:
            var result = Exercise.BubbleSort(inputArray);

            // assert:
            result.Should().ContainInOrder(expectedOutput);
        }
    }
}