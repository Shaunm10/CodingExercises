namespace CodingExercises.ThreeNumberSum
{
    public class Tests
    {
        public void TestA()
        {
            // arrange:
            var input = new int[]{12, 3, 1, 2, -6, 5, -8, 6};
            var targetSum =0;
            var expectedOutput = new List<int[]>
            {
                new int[]{-8, 2, 6},
                new int[]{-8, 3, 5},
                new int[]{-6, 1, 5}
            };

            // act:
            var result = Exercise.ThreeNumberSum(input, targetSum);

            // assert:
            result.Should().ContainInOrder(expectedOutput);
        }
    }
}