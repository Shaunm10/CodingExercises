namespace CodingExercies.RemoveDuplicatesFromLinkedList
{
    public class Exercise
    {
        /*
        You're given the head of a Singly Linked List whose nodes are in sorted order with respect to their values. 
        Write a function that returns a modified version of the Linked List that doesn't contain any nodes with duplicate values. 
        The Linked List should be modified in place (i.e., you shouldn't create a brand new list), 
        and the modified Linked List should still have its nodes sorted with respect to their values.

        Each LinkedList node has an integer value as well as a next node pointing to the next 
        node in the list or to None / null if it's the tail of the list.
        */
        public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            var set = new HashSet<int>();

            // initialize the first node
            var currentNode = linkedList;

            // to keep track of previous nodes as we process them.
            LinkedList previousNode = null;

            while (currentNode.next != null)
            {
                // has this value been seen?
                if (set.Contains(currentNode.value))
                {
                    var nextNode = currentNode.next;
                    previousNode.next = nextNode;

                }
                else
                {
                    // add it to the list.
                    set.Add(currentNode.value);

                }

                // record current as previous
                previousNode = currentNode;

                // set up for the next iteration.
                currentNode = currentNode.next;

            }

            return linkedList;
        }
    }
}