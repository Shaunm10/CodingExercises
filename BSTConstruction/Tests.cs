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

            // act:
            var newRoot = root.Remove(10);
            var resultForContains10 = newRoot.Contains(10);
            var resultForContains15 = newRoot.Contains(15);

            // assert:
            resultForContains10.Should().Be(false);
            resultForContains15.Should().Be(true);
        }
    }
}