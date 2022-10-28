namespace CodingExercises.CaesarCipherEncryptor
{
    public class Tests
    {
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
    }
}