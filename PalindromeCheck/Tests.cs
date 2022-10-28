namespace CodingExercises.PalindromeCheck
{
    public class Tests
    {

        [Fact]
        public void TestA()
        {
            // arrange:
            var sample = "abcdcba";
            var expectedOutput = true;

            // act:
            var result = Exercise.IsPalindrome(sample);

            // assert:
            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void TestB()
        {
            // arrange:
            var sample = "abcrdcba";
            var expectedOutput = false;

            // act:
            var result = Exercise.IsPalindrome(sample);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}