namespace CodingExercises.FindKthLargestValueInBST
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange;
            var rootBst = new BST
            {
                value = 15,
                left = new BST
                {
                    value = 5,
                    left = new BST
                    {
                        value = 2,
                        left = new BST
                        {
                            value = 1
                        },
                        right = new BST
                        {
                            value = 3
                        }
                    },
                    right = new BST
                    {
                        value = 5
                    }
                },
                right = new BST
                {
                    value = 20,
                    left = new BST
                    {
                        value = 17
                    },
                    right = new BST
                    {
                        value = 22
                    }
                }
            };
            var k = 3;
            var expectedResult = 17;

            // act:
            var response = new Exercise().FindKthLargestValueInBst(rootBst, k);

            // assert:
            response.Should().Be(expectedResult);
        }
    }
}