namespace CodingExercises.BinaryTreeDiameter
{
    public class Exercise
    {
        /*
        
        Write a function that takes in a Binary Tree and returns its diameter. 
        The diameter of a binary tree is defined as the length of its longest 
        path, even if that path doesn't pass through the root of the tree.

        A path is a collection of connected nodes in a tree, 
        where no node is connected to more than two other nodes. 
        The length of a path is the number of edges between 
        the path's first node and its last node.

        Each BinaryTree node has an integer value, a left 
        child node, and a right child node. Children nodes 
        can either be BinaryTree nodes themselves or None / null.
        */

        public int BinaryTreeDiameter(BinaryTree tree)
        {
            var diameterInfo = CalculateBinaryTreeDiameter(tree);

            return diameterInfo.Candidates.Append(diameterInfo.CurrentRunningLength).Max();
        }

        private DiameterInfo CalculateBinaryTreeDiameter(BinaryTree tree)
        {

            // this is a leaf
            if (tree.left == null && tree.right == null)
            {
                return new DiameterInfo();
            }

            // this is a branching node.
            else if (tree.left != null && tree.right != null)
            {
                var leftDiameterInfo = CalculateBinaryTreeDiameter(tree.left);
                var rightDiameterInfo = CalculateBinaryTreeDiameter(tree.right);
                leftDiameterInfo.CurrentRunningLength++;
                rightDiameterInfo.CurrentRunningLength++;

                var newCandidateList = new List<int>();
                newCandidateList.AddRange(leftDiameterInfo.Candidates);
                newCandidateList.AddRange(rightDiameterInfo.Candidates);

                // now add this diameter
                newCandidateList.Add(leftDiameterInfo.CurrentRunningLength + rightDiameterInfo.CurrentRunningLength);


                return new DiameterInfo
                {
                    Candidates = newCandidateList,
                    CurrentRunningLength = 0
                };
            }

            else if (tree.right != null)
            {
                var info = CalculateBinaryTreeDiameter(tree.right);

                // increment 
                info.CurrentRunningLength++;

                // return
                return info;

            }
            else
            {
                // finally this must only have a left
                var info = CalculateBinaryTreeDiameter(tree.left);

                info.CurrentRunningLength++;

                return info;
            }
        }


    }
    public class DiameterInfo
    {
        // public DiameterInfo()
        // {
        //     this.CurrentRunningLength = 0;
        //     this.Candidates = new List<int>();
        // }

        public int CurrentRunningLength =0;
        public List<int> Candidates = new List<int>();
    }

}