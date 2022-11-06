namespace CodingExercises.BSTConstruction
{
    public class Tests
    {
        [Fact]
        public void InsertTrue()
        {
            // arrange;
            var root = new BST(10)
                .Insert(5)
                .Insert(15)
                .Insert(2)
                .Insert(5)
                .Insert(13)
                .Insert(22)
                .Insert(1)
                .Insert(14);

            var expectedResult = true;

            // act:
            root.Insert(12);
            var result = root.Contains(12);

            // assert:
            result.Should().Be(expectedResult);

        }

        [Fact]
        public void InsertFalse()
        {
            // arrange;
            var root = new BST(10);
            root
                .Insert(5)
                .Insert(15)
                .Insert(2)
                .Insert(5)
                .Insert(13)
                .Insert(22)
                .Insert(1)
                .Insert(14);

            var expectedResult = false;

            // act:
            root.Insert(27);
            var result = root.Contains(12);

            // assert:
            result.Should().Be(expectedResult);

        }

        [Fact]
        public void Remove()
        {
            // arrange;
            var root = new BST(10)
                .Insert(5)
                .Insert(15)
                .Insert(2)
                .Insert(5)
                .Insert(13)
                .Insert(22)
                .Insert(1)
                .Insert(14);

            var expectedResult = false;
            var expectedResult2 = true;

            // act:
            var newRoot = root.Remove(10);
            var result = newRoot.Contains(10);
            var result2 = newRoot.Contains(15);

            // assert:
            result.Should().Be(expectedResult);
            result2.Should().Be(expectedResult2);
        }
    }
}