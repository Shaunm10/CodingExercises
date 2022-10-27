namespace CodingExercises.BubbleSort
{
    public class Exercise
    {
        /*
        Write a function that takes in an array of integers and returns a sorted version of that array. 
        Use the Bubble Sort algorithm to sort the array.

        If you're unfamiliar with Bubble Sort, we recommend watching the Conceptual 
        Overview section of this question's video explanation before starting to code.
        */

        public static int[] BubbleSort(int[] array)
        {
            for (var start = 0; start < array.Count(); start++)
            {
                var wasSwapPerformed = false;
                for (var end = start + 1; end < array.Count(); end++)
                {
                    var swapped = SwapIfNeeded(array, start, end);

                    // see if we did a swap, and if so we need to keep going.
                    if (swapped)
                    {
                        wasSwapPerformed = true;
                    }
                }
            }

            return array;
        }

        public static bool SwapIfNeeded(int[] array, int startIndex, int endIndex)
        {
            var firstItem = array[startIndex];
            var secondItem = array[endIndex];
            var wasASwapPerformed = false;

            if (firstItem > secondItem)
            {
                // a swap is needed
                wasASwapPerformed = true;
                array[endIndex] = firstItem;
                array[startIndex] = secondItem;
            }

            return wasASwapPerformed;
        }
    }
}