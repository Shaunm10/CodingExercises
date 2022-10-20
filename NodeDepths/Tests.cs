namespace CodingExercises.NodeDepths
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var expectedResult = 16;

            var tree = new BinaryTree(1)
            {
                left = new BinaryTree(2)
                {
                    left = new BinaryTree(4)
                    {
                        left = new BinaryTree(8),
                        right = new BinaryTree(9)
                    },
                    right = new BinaryTree(5)

                },
                right = new BinaryTree(3)
                {
                    left = new BinaryTree(6),
                    right = new BinaryTree(7)
                }
            };

            // act:
            var result = Exercise.NodeDepths(tree);

            // assert:
            result.Should().Be(expectedResult);
        }
    }
}