namespace CodingExercises.SmallestDifference
{
    public class Tests
    {
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
    }
}