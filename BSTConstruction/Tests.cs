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
            var root = new BST(10);
            root.value.Should().Be(10);

            // insert 5, root should be 10
            root.Insert(5).value.Should().Be(10);

            // insert 15 root should be 10
            root.Insert(15).value.Should().Be(10);

            root.Contains(10).Should().Be(true);

            root.Contains(5).Should().Be(true);

            root.Contains(15).Should().Be(true);
            root = root.Remove(10);
            root.value.Should().Be(15);


        }

        [Fact]
        public void Test7()
        {
            var root = new BST(1);
            root.value.Should().Be(1);

            // insert 2, root should be 1
            root.Insert(2).value.Should().Be(1);

            // insert 3, root should be 1
            root.Insert(3).value.Should().Be(1);

            // insert 4, root should be 1
            root.Insert(4).value.Should().Be(1);

            root = root.Remove(1);
            root.value.Should().Be(2);
        }

        [Fact]
        public void Test9()
        {
            var root = new BST(10);
            root = root.Insert(5);
            root.value.Should().Be(10);

            root = root.Remove(10);
            root.value.Should().Be(5);

            root.Contains(15).Should().BeFalse();

            root.value.Should().Be(5);
        }
    }
}