namespace CodingExercises.MergeOverlappingIntervals
{
    public class Tests
    {
        [Fact]
        public void testA()
        {
            // arrange:
            int[][] intervals = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 },
                new int[] { 4, 7 },
                new int[] { 6, 8 },
                new int[] { 9, 10 }
            };

            var expectedOutput = new int[][]
            {
                new int[] {1,2},
                new int[] {3,8},
                new int[] {9,10}
            };

            // act:
            var result = Exercise.MergeOverlappingIntervals(intervals);

            // assert:
            result.Should().BeEquivalentTo(expectedOutput);
        }
    }
}