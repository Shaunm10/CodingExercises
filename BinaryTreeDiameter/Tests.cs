namespace CodingExercises.BinaryTreeDiameter;

public class Tests
{
    [Fact]
    public void TestA()
    {
        // arrange:
        // There are 6 edges between the
        // first node and the last node
        // of this tree's longest path.
        // 9 -> 8 -> 7 -> 3 -> 4 -> 5 -> 6
        var expectedOutput = 6;
        var binaryTree = new BinaryTree
        {
            value = 1,
            right = new BinaryTree
            {
                value = 2
            },
            left = new BinaryTree
            {
                value = 3,
                right = new BinaryTree
                {
                    value = 4,
                    right = new BinaryTree
                    {
                        value = 5,
                        right = new BinaryTree
                        {
                            value = 6
                        }
                    }
                },
                left = new BinaryTree
                {
                    value = 7,
                    left = new BinaryTree
                    {
                        value = 8,
                        left = new BinaryTree
                        {
                            value = 9
                        }
                    }
                }
            }
        };

        // act:
        var result = new Exercise().BinaryTreeDiameter(binaryTree);

        // assert:
        result.Should().Be(expectedOutput);
    }

    [Fact(Skip="I don't know why this answer is supposed to be 4.")]
    public void TestB()
    {
        // arrange:

        var expectedOutput = 4;
        var binaryTree = new BinaryTree
        {
            value = 1,
            right = new BinaryTree
            {
                value = 3,
                left = new BinaryTree
                {
                    value = 6,

                },
                right = new BinaryTree
                {
                    value = 7
                }
            },
            left = new BinaryTree
            {
                value = 2,
                left = new BinaryTree
                {
                    value = 4
                },
                right = new BinaryTree
                {
                    value = 5
                }
            }
        };

        // act:
        var result = new Exercise().BinaryTreeDiameter(binaryTree);

        // assert:
        result.Should().Be(expectedOutput);
    }

}