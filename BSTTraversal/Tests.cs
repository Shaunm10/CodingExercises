namespace CodingExercises.BSTTraversal
{
    public class Tests
    {
        [Fact]
        public void InOrderTraverse()
        {
            // arrange:
            var startingTree = this.StartingTreeDesc;
            var array = new List<int>();
            var expectedResult = new List<int?> { 1, 2, 5, 5, 10, 15, 22 };

            // act:
            var result = Exercise.InOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult, cfg => cfg.WithStrictOrdering());
        }

        [Fact]
        public void PreOrderTraverse()
        {
            // arrange:
            var startingTree = this.StartingTreeDesc;
            var array = new List<int>();
            var expectedResult = new List<int?> { 10, 5, 2, 1, 5, 15, 22 };

            // act:
            var result = Exercise.PreOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult, cfg => cfg.WithStrictOrdering());

        }

        [Fact]
        public void PostOrderTraverse()
        {
            // arrange:
            var startingTree = this.StartingTreeDesc;
            var array = new List<int>();
            var expectedResult = new List<int?> { 1, 2, 5, 5, 22, 15, 10 };

            // act:
            var result = Exercise.PostOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult, cfg => cfg.WithStrictOrdering());
        }

        #region [Exercise One]
        [Fact]
        public void InOrderTraverseExerciseOne()
        {
            // arrange:
            var startingTree = this.StartTreeCaseOne;
            var array = new List<int>();
            var expectedResult = new List<int?> { 1, 2, 5, 5, 10, 15, 22 };

            // act:
            var result = Exercise.InOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult, cfg => cfg.WithStrictOrdering());
        }

        [Fact]
        public void PreOrderTraverseExerciseOne()
        {
            // arrange:
            var startingTree = this.StartTreeCaseOne;
            var array = new List<int>();
            var expectedResult = new List<int?> { 10, 5, 2, 1, 5, 15, 22 };

            // act:
            var result = Exercise.PreOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult, cfg => cfg.WithStrictOrdering());

        }

        [Fact]
        public void PostOrderTraverseExerciseOne()
        {
            // arrange:
            var startingTree = this.StartTreeCaseOne;
            var array = new List<int>();
            var expectedResult = new List<int?> { 1, 2, 5, 5, 22, 15, 10 };

            // act:
            var result = Exercise.PostOrderTraverse(startingTree, array);

            // assert:
            result.Should().BeEquivalentTo(expectedResult, cfg => cfg.WithStrictOrdering());
        }
        #endregion

        private BST StartingTreeDesc
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

        private BST StartTreeCaseOne
        {
            get
            {
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

                        }
                    }
                };

                return root;

            }
        }
    }
}