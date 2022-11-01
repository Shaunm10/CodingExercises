namespace CodingExercises.MoveElementToEnd
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var array = new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
            var toMove = 2;
            var expectedOutput = new List<int> { 1, 3, 4, 2, 2, 2, 2, 2 }; // the numbers 1, 3, and 4 could be ordered differently}

            // act:
            var result = Exercise.MoveElementToEnd(array, toMove);

            // assert:
            result.Should().BeEquivalentTo(expectedOutput);

        }
    }
}