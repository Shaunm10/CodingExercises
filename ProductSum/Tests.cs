namespace CodingExercises.ProductSum
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            List<object> input = new List<object>
            {
                5,
                2,
                new List<object>
                {
                    7,
                    -1
                },
                3,
                new List<object>
                {
                    6,
                    new List<object>
                    {
                        -13,
                        8
                    },
                    4
                }
            };

            var expectedOutput = 12;

            // act:
            var result = Exercise.ProductSum(input);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}