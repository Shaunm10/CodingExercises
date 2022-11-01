namespace CodingExercises.MonotonicArray
{
    public class Exercise
    {
        /*
        
        Write a function that takes in an array of integers and returns a boolean representing 
        whether the array is monotonic.

        An array is said to be monotonic if its elements, from left to right, 
        are entirely non-increasing or entirely non-decreasing.

        Non-increasing elements aren't necessarily exclusively decreasing; 
        they simply don't increase. Similarly, non-decreasing elements aren't necessarily 
        exclusively increasing; they simply don't decrease.

        Note that empty arrays and arrays of one element are monotonic.
        */
        public static bool IsMonotonic(int[] array)
        {
            var isMonotonic = true;
            bool? isIncreasing = null;
            int? lastNumber = null;

            for (var i = 0; i < array.Length; i++)
            {
                var item = array[i];

                // if we have a lastNumber, but haven't specified we are are decreasing
                // or increasing.
                if (lastNumber != null && isIncreasing == null)
                {
                    // if the last name is bigger
                    if (lastNumber > item)
                    {
                        // than we are in decrease mode.
                        isIncreasing = false;
                    }

                    if (lastNumber < item)
                    {
                        // than we are in increase mode.
                        isIncreasing = true;
                    }
                }

                // if we know the increase or decreasing
                if (isIncreasing.HasValue && isIncreasing.Value)
                {
                    if (item < lastNumber)
                    {
                        isMonotonic = false;
                    }
                }

                if (isIncreasing.HasValue && !isIncreasing.Value)
                {
                    if (item > lastNumber)
                    {
                        isMonotonic = false;
                    }
                }

                lastNumber = item;

            }

            return isMonotonic;
        }
    }
}