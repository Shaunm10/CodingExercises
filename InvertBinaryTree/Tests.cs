namespace CodingExercises.InvertBinaryTree
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var binaryTree = new BinaryTree
            {
                value = 1,
                left = new BinaryTree
                {
                    value = 2,
                    left = new BinaryTree
                    {
                        value = 4,
                        right = new BinaryTree
                        {
                            value = 9
                        },
                        left = new BinaryTree
                        {
                            value = 8
                        }
                    },
                    right = new BinaryTree
                    {
                        value = 5
                    }
                },
                right = new BinaryTree
                {
                    value = 3,
                    left = new BinaryTree
                    {
                        value = 6
                    },
                    right = new BinaryTree
                    {
                        value = 7
                    }
                }
            };



            // act:
            Exercise.InvertBinaryTree(binaryTree);

            // assert:
            binaryTree.value.Should().Be(1);
            binaryTree.left.value.Should().Be(3);
            binaryTree.left.left.value.Should().Be(7);
            binaryTree.left.right.value.Should().Be(6);


            binaryTree.right.value.Should().Be(2);
            binaryTree.right.left.value.Should().Be(5);
            binaryTree.right.right.value.Should().Be(4);
            binaryTree.right.right.left.value.Should().Be(9);
            binaryTree.right.right.right.value.Should().Be(8);





        }
    }
}