namespace CodingExercises.SelectionSort
{
    public class Exercise
    {
        public static int[] SelectionSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var movingCandidate = array[i];
                int smallestIndex = FindSmallestIndexAfter(array, i);
                var smallestNumber = array[smallestIndex];
                array[smallestIndex] = movingCandidate;
                array[i] = smallestNumber;
            }

            return array;
        }

        private static int FindSmallestIndexAfter(int[] array, int index)
        {
            var numCandidate = int.MaxValue;
            var indexCandidate = index;
            for (var i = index; i < array.Length; i++)
            {
                var number = array[i];
                if (number < numCandidate)
                {
                    indexCandidate = i;
                    numCandidate = number;
                }
            }

            return indexCandidate;
        }
    }
}