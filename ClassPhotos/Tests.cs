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

        [Fact]
        public void TestB()
        {
            // arrange:
            var exercise = new Exercise();
            var redShirtHeights = new List<int>
            {
                5, 8, 1, 3, 4, 9
            };
            var blueShirtHeights = new List<int>
            {
                6, 9, 2, 4, 5, 1
            };
            var expectedOutput = false;


            // act:
            var result = exercise.ClassPhotos(redShirtHeights, blueShirtHeights);

            // assert:
            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void TestC()
        {
            // arrange:
            var exercise = new Exercise();
            var redShirtHeights = new List<int>
            {
                6
            };
            var blueShirtHeights = new List<int>
            {
                6
            };
            var expectedOutput = false;


            // act:
            var result = exercise.ClassPhotos(redShirtHeights, blueShirtHeights);

            // assert:
            result.Should().Be(expectedOutput);
        }

        [Fact]
        public void TestD()
        {
            // arrange:
            var exercise = new Exercise();
            var redShirtHeights = new List<int>
            {
               3, 5, 6, 8, 2
            };
            var blueShirtHeights = new List<int>
            {
                2, 4, 7, 5, 1
            };
            var expectedOutput = true;


            // act:
            var result = exercise.ClassPhotos(redShirtHeights, blueShirtHeights);

            // assert:
            result.Should().Be(expectedOutput);
        }

    }
}