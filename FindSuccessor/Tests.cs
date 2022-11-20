namespace CodingExercises.FindSuccessor
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            // Write your code here.
            var rootTree = new BinaryTree(1);

            var twoNode = new BinaryTree(2);
            twoNode.parent = rootTree;
            rootTree.left = twoNode;

            var threeNode = new BinaryTree(3);
            threeNode.parent = rootTree;
            rootTree.right = threeNode;

            var fourNode = new BinaryTree(4);
            fourNode.parent = twoNode;
            twoNode.left = fourNode;

            var sixNode = new BinaryTree(6);
            sixNode.parent = fourNode;
            fourNode.left = sixNode;

            var fiveNode = new BinaryTree(6);
            fiveNode.parent = twoNode;
            twoNode.right = fiveNode;


            // This tree's in-order traversal order is:
            // 6 -> 4 -> 2 -> 5 -> 1 -> 3 
            // 1 comes immediately after 5.
            var expectedResult = 1;

            // act:
            var result = new Exercise().FindSuccessor(rootTree, fiveNode);

            // assert:
            result.Should().Be(expectedResult);

        }
    }
}