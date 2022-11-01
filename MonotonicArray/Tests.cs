namespace CodingExercises.MonotonicArray
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var array = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
            var expectedOutput = true;

            // act:
            var result = Exercise.IsMonotonic(array);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}