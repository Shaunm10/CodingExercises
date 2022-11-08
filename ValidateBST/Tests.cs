namespace CodingExercises.ValidateBST;

public class Tests
{

    [Fact]
    public void TestA()
    {
        // arrange:
        var root = new BST
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
                right = new BST
                {
                    value = 22
                },
                left = new BST
                {
                    value = 13,
                    right = new BST
                    {
                        value = 14
                    }
                }
            }
        };

        // act:
        var result = Exercise.ValidateBst(root);

        // assert:
        result.Should().Be(true);
    }

    [Fact]
    public void Test6()
    {
        // arrange:
        var root = new BST
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
                    value = 5,
                    right = new BST
                    {
                        value = 11,

                    }
                }
            },
            right = new BST
            {
                value = 15,
                right = new BST
                {
                    value = 22
                }
            }
        };

        // act:
        var result = Exercise.ValidateBst(root);

        // assert:
        result.Should().Be(false);
    }

    [Fact]
    public void Test11()
    {
        var root = new BST
        {
            value = 10,
            left = new BST
            {
                value = 5,
                right = new BST
                {
                    value = 10
                }
            },
            right = new BST
            {
                value = 15
            }
        };

        // act:
        var result = Exercise.ValidateBst(root);

        // assert:
        result.Should().Be(false);
    }
}
