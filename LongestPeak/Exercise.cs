namespace CodingExercises.LongestPeak
{
    public class Exercise
    {

        /*
        Write a function that takes in an array of integers and returns the length of the longest 
        peak in the array.

        A peak is defined as adjacent integers in the array that are strictly increasing 
        until they reach a tip (the highest value in the peak), at which point they become 
        strictly decreasing. At least three integers are required to form a peak.

        For example, the integers 1, 4, 10, 2 form a peak, but the integers 
        4, 0, 10 don't and neither do the integers 1, 2, 2, 0. Similarly, 
        the integers 1, 2, 3 don't form a peak because there aren't 
        any strictly decreasing integers after the 3.
        */

        public static int LongestPeak(int[] array)
        {
            var largestRangeSize = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (IsPeakValue(i, array))
                {
                    int rangeBefore = GetRange(i, RangeDirection.Before, array);
                    int rangeAfter = GetRange(i, RangeDirection.After, array);

                    // add up the total range size
                    var totalRange = rangeBefore + 1 + rangeAfter;

                    // if this is the new biggest range
                    if (totalRange > largestRangeSize)
                    {
                        largestRangeSize = totalRange;
                    }

                    // bump up index because we can skip the next few checks since it's on a decline
                    i = i + rangeAfter;
                }
            }

            return largestRangeSize;
        }

        private static int GetRange(int targetIndex, RangeDirection rangeDirection, int[] array)
        {
            var sequenceCount = 0;
            var lastNumber = array[targetIndex];

            if (rangeDirection == RangeDirection.After)
            {
                for (var i = targetIndex + 1; i < array.Length; i++)
                {
                    var nextNumber = array[i];

                    // while the steps are moving down.
                    if (nextNumber < lastNumber)
                    {
                        sequenceCount++;
                        lastNumber = nextNumber;
                    }
                    else
                    {
                        // we got to the end of the sequence.
                        return sequenceCount;
                    }
                }

                return sequenceCount;
            }
            else
            {
                for (var i = targetIndex - 1; i >= 0; i--)
                {
                    var nextNumber = array[i];

                    // while the steps are moving down.
                    if (nextNumber < lastNumber)
                    {
                        sequenceCount++;
                        lastNumber = nextNumber;
                    }
                    else
                    {
                        // we got to the end of the sequence.
                        return sequenceCount;
                    }
                }

                return sequenceCount;

            }
        }

        private static bool IsPeakValue(int index, int[] array)
        {
            // if its the first element
            if (index == 0)
            {
                return false;
            }

            // if it's the last element.
            if (index + 1 == array.Length)
            {
                return false;
            }

            var valueBefore = array[index - 1];
            var valueAtIndex = array[index];
            var valueAfter = array[index + 1];

            return valueBefore < valueAtIndex && valueAtIndex > valueAfter;
        }

        private enum RangeDirection
        {
            Before,
            After
        }
    }
}