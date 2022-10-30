namespace CodingExercises.FirstNonRepeatingCharacter
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var input = "abcdcaf";
            var expectedOutput = 1;

            // act:
            var result = Exercise.FirstNonRepeatingCharacter(input);

            // asset:
            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void TestB()
        {
            // arrange:
            var input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
            var expectedOutput = -1;

            // act:
            var result = Exercise.FirstNonRepeatingCharacter(input);

            // asset:
            result.Should().Be(expectedOutput);
        }
    }
}