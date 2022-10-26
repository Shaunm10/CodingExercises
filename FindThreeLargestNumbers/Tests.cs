namespace CodingExercises.FindThreeLargestNumbers
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var array = new int[] { };
            var expectedOutput = new int[] { 18, 141, 541 };

            // act:
            var result = Exercise.FindThreeLargestNumbers(array);

            // assert:
            array.Should().ContainInOrder(expectedOutput);
        }
    }
}