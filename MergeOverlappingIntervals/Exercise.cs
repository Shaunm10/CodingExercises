namespace CodingExercises.MergeOverlappingIntervals
{
    public class Exercise
    {
        /*
        Write a function that takes in a non-empty array of arbitrary intervals, 
        merges any overlapping intervals, and returns the new intervals in no particular order.

        Each interval interval is an array of two integers, with interval[0] 
        as the start of the interval and interval[1] as the end of the interval.

        Note that back-to-back intervals aren't considered to be overlapping. 
        For example, [1, 5] and [6, 7] aren't overlapping; however, [1, 6] and [6, 7] 
        are indeed overlapping.

        Also note that the start of any particular interval will always 
        be less than or equal to the end of that interval.
        */
        public static int[][] MergeOverlappingIntervals(int[][] intervals)
        {
            var uniqueIntervals = new int[][] { };

            for (var i = 0; i < intervals.Length; i++)
            {
                var interval = intervals[0];

                int[] overlappingIndexes = GetOverlappingIntervalIndexes(uniqueIntervals, interval);

                if (overlappingIndexes.Length == 0)
                {
                    // add this interval to the list.
                    uniqueIntervals = uniqueIntervals.Append(interval).ToArray();

                }
                else
                {
                    // combine them into 1 big interval
                    int[] combinedInterval = CombineIntervals(uniqueIntervals, overlappingIndexes, interval);

                    // remove the exiting overlapping ones.
                    RemoveIntervals(uniqueIntervals, overlappingIndexes);

                    // add this new combined one.
                    uniqueIntervals = uniqueIntervals.Append(combinedInterval).ToArray();
                }
            }

            // Write your code here.
            return uniqueIntervals;
        }

        private static void RemoveIntervals(int[][] uniqueIntervals, int[] overlappingIndexes)
        {
            throw new NotImplementedException();
        }

        private static int[] CombineIntervals(int[][] uniqueIntervals, int[] overlappingIndexes, int[] interval)
        {
            throw new NotImplementedException();
        }

        private static int[] GetOverlappingIntervalIndexes(int[][] uniqueIntervals, int[] interval)
        {
            var overlappingIndexes = new int[] { };

            for (var i = 0; i < uniqueIntervals.Length; i++)
            {

            }

            return overlappingIndexes;
        }
    }
}