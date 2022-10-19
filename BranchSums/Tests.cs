namespace CodingExercises.BranchSums
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            // arrange:
            var targetTree = new BinaryTree
            {
                value = 1,
                left = new BinaryTree
                {
                    value = 2,
                    left = new BinaryTree
                    {
                        value = 4,
                        left = new BinaryTree
                        {
                            value = 8
                        },
                        right = new BinaryTree
                        {
                            value = 9
                        }
                    },
                    right = new BinaryTree
                    {
                        value = 5,
                        left = new BinaryTree
                        {
                            value = 10
                        }
                    }

                },
                right = new BinaryTree
                {
                    value = 3,
                    right = new BinaryTree
                    {
                        value = 7
                    },
                    left = new BinaryTree
                    {
                        value = 6
                    }
                }
            };

            var expectedOutput = new int[] { 15, 16, 18, 10, 11 };

            // act:
            var result = Exercise.BranchSums(targetTree);

            // assert:
            result.Should().ContainInOrder(expectedOutput);
        }
    }
}