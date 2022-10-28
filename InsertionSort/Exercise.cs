namespace CodingExercises.InsertionSort
{
    public class Exercise
    {
        public static int[] InsertionSort(int[] array)
        {
            // array that will have the output.
            int?[] sortedList = new int?[array.Length];

            // iterate through all the items in the original array.
            for (var i = 0; i < array.Length; i++)
            {
                // pluck out the current value being evaluated
                var movingCandidate = array[i];

                // get what the index of where the item belongs.
                int indexOfInsertion = GetIndexOfInsertion(sortedList, movingCandidate);

                AddItemToArray(sortedList, movingCandidate, indexOfInsertion);
            }

            // Write your code here.
            return sortedList.Select(x => x.GetValueOrDefault()).ToArray();
        }

        private static void AddItemToArray(int?[] sortedList, int movingCandidate, int indexOfInsertion)
        {
            // move all the other items to the right by one, starting at the end.
            for (var i = sortedList.Length - 1; i >= indexOfInsertion; i--)
            {
                var itemToMove = sortedList[i];
                if (itemToMove != null)
                {
                    sortedList[i + 1] = itemToMove;
                }
            }

            // now finally add the item to the targeted index
            sortedList[indexOfInsertion] = movingCandidate;
        }


        private static int GetIndexOfInsertion(int?[] sortedList, int insertionCandidate)
        {
            var candidateIndex = 0;
            for (var i = 0; i < sortedList.Length; i++)
            {
                var existingItemAtIndex = sortedList[i];

                if (insertionCandidate > existingItemAtIndex)
                {
                    candidateIndex = i;
                }
                // otherwise keep moving through the list.
            }

            // if we went through all the items and we 
            // couldn't find an item larger than the candidate
            // return the last row.
            return candidateIndex;
        }
    }
}