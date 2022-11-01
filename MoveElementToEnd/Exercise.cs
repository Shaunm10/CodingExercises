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
            var indexesToMove = new List<int>();

            for (var i = 0; i < array.Count; i++)
            {
                var valueAtIndex = array[i];
                if (valueAtIndex == toMove)
                {
                    indexesToMove.Add(i);
                }
            }

            // sort the array so largest index appears first.
            indexesToMove = indexesToMove.OrderByDescending(x => x).ToList();

            indexesToMove.ForEach(i =>
            {
                array.RemoveAt(i);
                array = array.Append(toMove).ToList();
            });

            // Write your code here.
            return array;
        }

    }
}