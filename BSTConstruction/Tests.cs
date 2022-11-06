namespace CodingExercises.BSTConstruction
{
    public class Tests
    {
        [Fact]
        public void InsertTrue()
        {
            // arrange;
            var root = new BST(10);
            root.Insert(5);
            root.Insert(15);
            root.Insert(2);
            root.Insert(5);
            root.Insert(13);
            root.Insert(22);
            root.Insert(1);
            root.Insert(14);
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
            root.Insert(5);
            root.Insert(15);
            root.Insert(2);
            root.Insert(5);
            root.Insert(13);
            root.Insert(22);
            root.Insert(1);
            root.Insert(14);
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
            var root = new BST(10);
            root.Insert(5);
            root.Insert(15);
            root.Insert(2);
            root.Insert(5);
            root.Insert(13);
            root.Insert(22);
            root.Insert(1);
            root.Insert(14);
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