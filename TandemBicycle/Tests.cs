namespace CodingExercises.TandemBicycle
{
    public class Tests
    {
        public void TestA()
        {
            // arrange:
            var redShirtSpeeds = new int[] { 5, 5, 3, 9, 2 };
            var blueShirtSpeeds = new int[] { 3, 6, 7, 2, 1 };
            var fastest = true;
            var expectedOutput = 32;

            // act:
            var result = Exercise.TandemBicycle(redShirtSpeeds, blueShirtSpeeds, fastest);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}