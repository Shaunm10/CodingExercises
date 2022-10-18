namespace CodingExercises.FindClosestValueInBST
{
    public class Tests
    {

        [Fact]
        public void Test1()
        {

            // arrange:
            var expectedOutput = 13;
            var head = new BST
            {
                value = 10,
                left = new BST
                {
                    value = 5,
                    left = new BST
                    {
                        value = 2,
                        left = new BST
                        {
                            value = 1
                        }
                    },
                    right = new BST
                    {
                        value = 5
                    }
                },
                right = new BST
                {
                    value = 15,
                    left = new BST
                    {
                        value = 13,
                        right = new BST
                        {
                            value = 14
                        }
                    },
                    right = new BST
                    {
                        value = 22
                    }
                }
            };

            // act:
            var answer = Exercise.FindClosestValueInBst(head, 10);

            // assert:
            answer.Should().Be(expectedOutput);

        }
    }
}