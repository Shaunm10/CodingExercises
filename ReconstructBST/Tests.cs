namespace CodingExercises.ReconstructBST;

public class Tests
{

    [Fact]
    public void TestA()
    {
        // arrange:
        var input = new List<int> { 10, 4, 2, 1, 5, 17, 19, 18 };
        var expectedBstOutput = new BST
        {
            value = 10,
            left = new BST
            {
                value = 4,
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
                value = 17,
                right = new BST
                {
                    value = 19,
                    left = new BST
                    {
                        value = 18
                    }
                }
            }
        };
        var expectedOutputJson = JsonSerializer.Serialize(expectedBstOutput, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        // act:
        var result = new Exercise().ReconstructBst(input);
        var resultJson = JsonSerializer.Serialize(result, new JsonSerializerOptions
        {
            WriteIndented = true

        });

        // assert:
        result.Should().NotBeNull();
        resultJson.Should().BeEquivalentTo(expectedOutputJson);
    }

    [Fact]
    public void TestB()
    {
        // arrange:
        var input = new List<int> { 2, 0, 1, 4, 3, 3 };
        var expectedBstOutput = new BST
        {
            value = 2,
            left = new BST
            {
                value = 0,
                right = new BST
                {
                    value = 1
                }
            },
            right = new BST
            {
                value = 4,
                left = new BST
                {
                    value = 3,
                    left = new BST
                    {
                        value = 3
                    }
                }
            }
        };
        var expectedOutputJson = JsonSerializer.Serialize(expectedBstOutput, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        // act:
        var result = new Exercise().ReconstructBst(input);
        var resultJson = JsonSerializer.Serialize(result, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        // assert:
        result.Should().NotBeNull();
        resultJson.Should().BeEquivalentTo(expectedOutputJson);
    }
}
