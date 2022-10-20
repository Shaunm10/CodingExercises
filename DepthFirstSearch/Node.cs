namespace CodingExercises.DepthFirstSearch
{
    /*    
        You're given a Node class that has a name and an array of optional children nodes. 
        When put together, nodes form an acyclic tree-like structure.

        Implement the depthFirstSearch method on the Node class, which takes in an empty array, 
        traverses the tree using the Depth-first Search approach (specifically navigating the tree from left to right), 
        stores all of the nodes' names in the input array, and returns it.

        If you're unfamiliar with Depth-first Search, we recommend watching the Conceptual 
        Overview section of this question's video explanation before starting to code.
    */

    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }

        public List<string> DepthFirstSearchLinq(List<string> array)
        {
            var nodeNames = new List<string>();
            nodeNames.Add(this.name);

            this.children.ForEach(x => nodeNames.AddRange(x.DepthFirstSearchLinq(array)));

            return nodeNames;
        }
        public List<string> DepthFirstSearch(List<string> array)
        {
            var nodeNames = new List<string>();
            nodeNames.Add(this.name);

            for (var i = 0; i < this.children.Count(); i++)
            {
                var childNodeNames = this.children[i].DepthFirstSearch(array);

                for (int chi = 0; chi < childNodeNames.Count(); chi++)
                {
                    nodeNames.Add(childNodeNames[chi]);
                }
            }

            return nodeNames;
        }

        public Node AddChild(string name)
        {
            Node child = new Node(name);
            children.Add(child);
            return this;
        }

        public Node AddChild(Node child)
        {
            children.Add(child);
            return this;
        }

    }
}