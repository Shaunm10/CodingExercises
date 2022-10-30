namespace CodingExercises.RunLengthEncoding
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange
            var input = "AAAAAAAAAAAAABBCCCCDD";
            var expectedOutput = "9A4A2B4C2D";

            // act
            var result = Exercise.RunLengthEncoding(input);

            // assert
            result.Should().Be(expectedOutput);
        }
    }
}