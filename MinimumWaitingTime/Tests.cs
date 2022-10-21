namespace CodingExercises.MinimumWaitingTime
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            // arrange:
            var input = new int[]
            {
                3, 2, 1, 2, 6
             };
            var expectedOutput = 17;

            // act:
            var result = Exercise.MinimumWaitingTime(input);

            // assert:
            result.Should().Be(expectedOutput);
        }

    }
}