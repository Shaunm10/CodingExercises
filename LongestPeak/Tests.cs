namespace CodingExercises.LongestPeak
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            //var array = new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
            int[] array = { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
            var expectedOutput = 6; // 0, 10, 6, 5, -1, -3

            // act:
            var result = Exercise.LongestPeak(array);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}