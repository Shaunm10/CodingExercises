namespace CodingExercises.BinarySearch
{
    public class Exercise
    {
        /*
        Write a function that takes in a sorted array of integers as well as a target integer. 
        The function should use the Binary Search algorithm to determine if the target integer 
        is contained in the array and should return its index if it is, otherwise -1.

        If you're unfamiliar with Binary Search, we recommend watching the 
        Conceptual Overview section of this question's video explanation before 
        starting to code.
        */

        public static int BinarySearch(int[] array, int target, int startIndex = 0)
        {
            if (array.Count() == 0)
            {
                return -1;
            }
            if (array.Count() == 1)
            {
                if (array[0] == target)
                {
                    return startIndex;
                }

                return -1;
            }
            var middleIndex = array.Count() / 2;

            var middleNumber = array[middleIndex];
            if (middleNumber == target)
            {
                return middleIndex + startIndex;
            }
            else if (middleNumber > target)
            {
                // operate on the 1st half
                var firstHalf = array.Take(middleIndex).ToArray();
                return BinarySearch(firstHalf, target, 0 + startIndex);
            }

            // operate on the 2nd half
            var secondHalf = array.Skip(middleIndex).Take(array.Count()).ToArray();
            return BinarySearch(secondHalf, target, middleIndex + startIndex);
        }
    }
}