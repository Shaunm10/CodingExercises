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
                var interval = intervals[i];

                var overlappingIndexes = GetOverlappingIntervalIndexes(uniqueIntervals, interval);

                if (overlappingIndexes.Count == 0)
                {
                    // add this interval to the list.
                    uniqueIntervals = uniqueIntervals.Append(interval).ToArray();
                }
                else
                {
                    // combine them into 1 big interval
                    int[] combinedInterval = CombineIntervals(uniqueIntervals, overlappingIndexes, interval);

                    // remove the exiting overlapping ones.
                    uniqueIntervals = RemoveIntervals(uniqueIntervals, overlappingIndexes);

                    // add this new combined one.
                    uniqueIntervals = uniqueIntervals.Append(combinedInterval).ToArray();
                }
            }

            // Write your code here.
            return uniqueIntervals;
        }

        private static int[][] RemoveIntervals(int[][] uniqueIntervals, List<int> overlappingIndexes)
        {
            var largeToSmallIndexes = overlappingIndexes.OrderByDescending(x => x).ToList();
            var uniqueIntervalsList = uniqueIntervals.ToList();

            for (var i = 0; i < largeToSmallIndexes.Count; i++)
            {
                var indexToBeRemoved = largeToSmallIndexes[i];

                uniqueIntervalsList.RemoveAt(indexToBeRemoved);

            }

            return uniqueIntervalsList.ToArray();
        }

        private static int[] CombineIntervals(int[][] uniqueIntervals, List<int> overlappingIndexes, int[] interval)
        {
            var combinedInterval = new int[] { interval[0], interval[1] };

            for (var i = 0; i < overlappingIndexes.Count; i++)
            {
                var index = overlappingIndexes[i];
                var existingInterval = uniqueIntervals[index];

                // see if we need to push out the beginning number
                if (existingInterval[0] < combinedInterval[0])
                {
                    combinedInterval[0] = existingInterval[0];
                }

                // see if we need to push out the end number.
                if (existingInterval[1] > combinedInterval[1])
                {
                    combinedInterval[1] = existingInterval[1];
                }
            }

            return combinedInterval;
        }

        private static List<int> GetOverlappingIntervalIndexes(int[][] uniqueIntervals, int[] candidate)
        {
            var overlappingIndexes = new List<int> { };

            for (var i = 0; i < uniqueIntervals.Length; i++)
            {
                var storedInterval = uniqueIntervals[i];

                // stored.Min < = candidate.Max + stored.Max >= cand.Min
                if (storedInterval[0] <= candidate[1] &&
                    storedInterval[1] >= candidate[0])
                {
                    overlappingIndexes.Add(i);

                }
            }

            return overlappingIndexes;
        }
    }
}