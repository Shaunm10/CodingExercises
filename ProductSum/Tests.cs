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
                new List<object> //6 X 2 = 12
                {
                    7,
                    -1
                },
                3,
                new List<object> // 10 X 2 = 20
                {
                    6,
                    new List<object>// -5 X 3 = -15
                    {
                        -13,
                        8
                    },
                    4
                }
            };

            //12 // calculated as: 5 + 2 + 2 * (7 - 1) + 3 + 2 * (6 + 3 * (-13 + 8) + 4)
            var expectedOutput = 12;

            // act:
            var result = Exercise.ProductSum(input);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}