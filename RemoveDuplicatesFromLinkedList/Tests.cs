namespace CodingExercies.RemoveDuplicatesFromLinkedList
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            //1 -> 1 -> 3 -> 4 -> 4 -> 4 -> 5 -> 6 -> 6
            // arrange:
            var inputList = new LinkedList(1)
            {
                next = new LinkedList(1)
                {
                    next = new LinkedList(3)
                    {
                        next = new LinkedList(4)
                        {
                            next = new LinkedList(4)
                            {
                                next = new LinkedList(4)
                                {
                                    next = new LinkedList(5)
                                    {
                                        next = new LinkedList(6)
                                        {
                                            next = new LinkedList(6)
                                            {

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            //1 -> 3 -> 4 -> 5 -> 6
            var expectedOutput = new LinkedList(1)
            {
                next = new LinkedList(3)
                {
                    next = new LinkedList(4)
                    {
                        next = new LinkedList(5)
                        {
                            next = new LinkedList(6)
                            {

                            }
                        }
                    }
                }
            };

            // act:
            var result = Exercise.RemoveDuplicatesFromLinkedList(inputList);

            // assert:
            result.Should().BeEquivalentTo(expectedOutput);
        }
    }
}