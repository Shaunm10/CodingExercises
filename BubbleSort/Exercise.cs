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
            for (var outerIndex = 0; outerIndex < array.Count(); outerIndex++)
            {
                var wasSwapPerformed = false;
                for (var innerIndex = outerIndex; innerIndex < array.Count() + 1; innerIndex++)
                {
                    var swapped = SwapIfNeeded(array, innerIndex, innerIndex + 1);

                    // see if we did a swap, and if so we need to keep going.
                    if (swapped)
                    {
                        wasSwapPerformed = true;
                    }
                }

                if (!wasSwapPerformed)
                {
                    break;
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