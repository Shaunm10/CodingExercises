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

        [Fact]
        public void TestA()
        {
            // arrange;
            var root = new BST(1);

            // act:
            root = root.Insert(-2);
            var step1Root = root.value;

            root = root.Insert(-3);
            var step2Root = root.value;

            root = root.Insert(-4);
            var step3Root = root.value;

            root = root.Remove(1);
            var step4Root = root.value;

            // assert:
            step1Root.Should().Be(1);
            step2Root.Should().Be(1);
            step3Root.Should().Be(1);
            step4Root.Should().Be(-2);
        }

        [Fact]
        public void TestB()
        {
            // arrange;
            var root = new BST(10);

            // act:
            root = root.Insert(5);
            var step1Root = root.value;

            root = root.Insert(15);
            var step2Root = root.value;

            root = root.Insert(10);
            root.Contains(10).Should().Be(true);
            root.Contains(5).Should().Be(true);
            root.Contains(15).Should().Be(true);

            root = root.Remove(10);
            root = root.Remove(5);


            root = root.Remove(1);
            var step4Root = root.value;

            // assert:
            step1Root.Should().Be(1);
            step2Root.Should().Be(1);
            step3Root.Should().Be(1);
            step4Root.Should().Be(-2);
        }
    }
}