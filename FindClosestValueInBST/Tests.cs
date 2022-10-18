namespace CodingExercises.FindClosestValueInBST
{
    public class Tests
    {

        [Fact]
        public void Test1()
        {

            // arrange:
            var expectedOutput = 13;
            var head = new BST
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
                    left = new BST
                    {
                        value = 13,
                        right = new BST
                        {
                            value = 14
                        }
                    },
                    right = new BST
                    {
                        value = 22
                    }
                }
            };

            // act:
            var answer = Exercise.FindClosestValueInBst(head, 12);

            // assert:
            answer.Should().Be(expectedOutput);

        }

        [Fact]
        public void Test2()
        {

            // arrange:
            var expectedOutput = 15;

            var head = new BST
            {
                value = 100,
                left = new BST
                {
                    value = 5,

                    right = new BST
                    {
                        value = 15,
                        left = new BST
                        {
                            value = 5
                        },
                        right = new BST
                        {
                            value = 22,
                            right = new BST
                            {
                                value = 57,
                                right = new BST
                                {
                                    value = 60
                                }
                            }
                        }
                    },
                    left = new BST
                    {
                        value = 2,
                        left = new BST
                        {
                            value = 1,
                            left = new BST
                            {
                                value = -51,
                                left = new BST
                                {
                                    value = -403
                                    // terminates here.
                                },
                                right = new BST
                                {
                                    value = 1,
                                    right = new BST
                                    {
                                        value = 1,
                                        right = new BST
                                        {
                                            value = 1,
                                            right = new BST
                                            {
                                                value = 1,
                                                // terminates here.
                                            }
                                        }
                                    }
                                }
                            }
                        },
                        right = new BST
                        {
                            value = 3
                            // terminates here.
                        }
                    }

                },
                right = new BST
                {
                    value = 502,
                    left = new BST
                    {
                        value = 204,
                        left = new BST
                        {
                            value = 203
                            // terminates

                        },
                        right = new BST
                        {
                            value = 205,
                            right = new BST
                            {
                                value = 207,
                                left = new BST
                                {
                                    value = 206
                                },
                                right = new BST
                                {
                                    value = 208
                                }
                            }
                        }
                    },
                    right = new BST
                    {
                        value = 5500,
                        left = new BST
                        {
                            value = 1001,
                            right = new BST
                            {
                                value = 4500
                            }
                        }

                    }
                }
            };

            // act:
            var answer = Exercise.FindClosestValueInBst(head, 12);

            // assert:
            answer.Should().Be(expectedOutput);

        }

    }
}