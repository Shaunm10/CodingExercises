namespace CodingExercises.BSTTraversal
{
    public class Tests
    {
        [Fact]
        public void InOrderTraverse()
        {
            // arrange:
            var startingTree = this.StartingTree;
            var array = new List<int>();
            var expectedResult = new List<int?> { 1, 2, 5, 5, 10, 15, 22 };

            // act:
            var result = Exercise.InOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void PreOrderTraverse()
        {
            // arrange:
            var startingTree = this.StartingTree;
            var array = new List<int>();
            var expectedResult = new List<int?> { 10, 5, 2, 1, 5, 15, 22 };

            // act:
            var result = Exercise.PreOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult);

        }

        [Fact]
        public void PostOrderTraverse()
        {
            // arrange:
            var startingTree = this.StartingTree;
            var array = new List<int>();
            var expectedResult = new List<int?> { 1, 2, 5, 5, 22, 15, 10 };


            // act:
            var result = Exercise.PostOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult);

        }

        private BST StartingTree
        {
            get
            {
                return new BST
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
                        }
                    }
                };

            }

        }
    }
}