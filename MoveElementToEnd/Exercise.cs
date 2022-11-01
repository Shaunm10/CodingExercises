namespace CodingExercises.MoveElementToEnd
{
    public class Exercise
    {

        /*
        You're given an array of integers and an integer. 
        Write a function that moves all instances of that integer in the 
        array to the end of the array and returns the array.

        The function should perform this in place (i.e., it should mutate the 
        input array) and doesn't need to maintain the order of the other integers.
        */
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            var indexesToMove = new int[] { };

            for (var i = 0; i < array.Count; i++)
            {
                var valueAtIndex = array[i];
                if (valueAtIndex == toMove)
                {
                    indexesToMove.Append(i);
                }
            }

            //array.
            // Write your code here.
            return new List<int>();
        }

    }
}