namespace CodingExercises.InsertionSort
{
    public class Test
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
            var expectedOutput = new int[] { 2, 3, 5, 5, 8, 9 };

            // act:
            var result = Exercise.InsertionSort(array);

            // assert:
            result.Should().ContainInOrder(expectedOutput);
        }
    }
}