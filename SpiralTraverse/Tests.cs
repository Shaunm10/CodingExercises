namespace CodingExercises.SpiralTraverse
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            int[,] array = {
                { 1,   2,  3, 4 },
                { 12, 13, 14, 5 },
                { 11, 16, 15, 6 },
                { 10,  9,  8, 7 }
            };

            var expectedOutput = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            // act:
            var result = Exercise.SpiralTraverse(array);

            // assert:
            result.Should().BeEquivalentTo(expectedOutput);
        }
    }
}