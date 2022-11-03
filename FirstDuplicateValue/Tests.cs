namespace CodingExercises.FirstDuplicateValue
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            int[] array = { 2, 1, 5, 3, 3, 2, 4 };
            var expectedOutput = 3; // 3 is the first integer that appears more than once. // 2 also appears more than once, but the second 2 appears after the second 3.

            // act:
            var result = Exercise.FirstDuplicateValue(array);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}