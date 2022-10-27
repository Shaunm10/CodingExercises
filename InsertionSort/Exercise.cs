namespace CodingExercises.InsertionSort
{
    public class Exercise
    {
        public static int[] InsertionSort(int[] array)
        {
            int[] sortedList = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                var movingCandidate = array[i];

                int indexOfInsertion = GetIndexOfInsertion(sortedList, movingCandidate);

            }

            // Write your code here.
            return new int[] { };
        }

        private static int GetIndexOfInsertion(int[] sortedList, int movingCandidate)
        {
            throw new NotImplementedException();
        }
    }
}