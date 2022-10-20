namespace CodingExercises.DepthFirstSearch
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            var expectedOutput = new List<string>
            {
                "A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H"
            };

            var nodeA = new Node("A");
            var nodeB = new Node("B");
            var nodeC = new Node("C");
            var nodeD = new Node("D");
            var nodeE = new Node("E");
            var nodeF = new Node("F");
            var nodeG = new Node("G");
            var nodeH = new Node("H");
            var nodeI = new Node("I");
            var nodeJ = new Node("J");
            var nodeK = new Node("K");

            // adds to A
            nodeA.AddChild(nodeB).AddChild(nodeC).AddChild(nodeD);
            
            // adds to B
            nodeB.AddChild(nodeE).AddChild(nodeF);

            // adds to F
            nodeF.AddChild(nodeI).AddChild(nodeJ);

            // adds to D
            nodeD.AddChild(nodeG).AddChild(nodeH);
           
            // adds to G
            nodeG.AddChild(nodeK);

            // act:
            var result = nodeA.DepthFirstSearch(new List<string>());

            // assert:
            result.Should().ContainInOrder(expectedOutput);
        }
    }
}