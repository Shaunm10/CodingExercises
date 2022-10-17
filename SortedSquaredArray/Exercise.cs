namespace CodingExercises.SortedSquaredArray
{
    public class Exercise
    {
        /*
        Write a function that takes in a non-empty array of integers that are sorted in ascending order and returns a new array of the same length with the squares of the original 
        integers also sorted in ascending order.
        */

        public static int[] SortedSquaredArrayLinq(int[] array)
        {
       
            return array
                .Select(x => x * x)
                .OrderBy(x =>x)
                .ToArray();
        }

        public static int[] SortedSquaredArray(int[] array)
        {
            var arrayLength = array.Length;
            var squaredArray = new int[arrayLength];
            var startPointer = 0;
            var endPointer = arrayLength;
            
            for(int i = 0; i < arrayLength; i++)
            {
                var valueAtBegin = array[startPointer];
                var valueAtEnd = array[endPointer-1];
                
                if(Math.Abs(valueAtBegin) >= Math.Abs(valueAtEnd))
                {
                    squaredArray[(arrayLength-1)-i] = valueAtBegin * valueAtBegin;
                    startPointer++;
                }
                else
                {     
                    squaredArray[(arrayLength-1)-i] = valueAtEnd * valueAtEnd;
                    endPointer--;
                }
            }

            return squaredArray;
        }
    }
}