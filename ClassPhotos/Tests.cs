namespace CodingExercises.ClassPhotos
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var exercise = new Exercise();
            var redShirtHeights = new List<int>
            {
                5, 8, 1, 3, 4
            };
            var blueShirtHeights = new List<int>
            {
                6, 9, 2, 4, 5
            };
            var expectedOutput = true;


            // act:
            var result = exercise.ClassPhotos(redShirtHeights, blueShirtHeights);

            // assert:
            result.Should().Be(expectedOutput);
        }
        
    }
}