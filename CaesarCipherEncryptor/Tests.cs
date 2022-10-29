namespace CodingExercises.CaesarCipherEncryptor
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var input = "xyz";
            var key = 2;
            var expectedOutput = "zab";

            // act:
            var result = Exercise.CaesarCypherEncryptor(input, key);

            // assert:
            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void TestB()
        {
            // arrange:
            var input = "abc";
            var key = 57;
            var expectedOutput = "abc";

            // act:
            var result = Exercise.CaesarCypherEncryptor(input, key);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}