namespace CodingExercises.NodeDepths
{
    public class Tests
    {
        public void TestA()
        {

            // arrange:
            var expectedResult = 16;
            var tree = new BinaryTree(1)
            {
                value = 1,
                left = new BinaryTree(2)
                {

                },
                right = new BinaryTree(3)
                {

                }
            };

            // act:
            var result = Exercise.NodeDepths(tree);

            // assert:
            result.Should().Be(expectedResult);
        }
    }
}