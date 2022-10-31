namespace CodingExercises.SmallestDifference
{
    public class Exercise
    {
        /*
        Write a function that takes in two non-empty arrays of integers, 
        finds the pair of numbers (one from each array) whose absolute 
        difference is closest to zero, and returns an array containing 
        these two numbers, with the number from the first array in the first position.

        Note that the absolute difference of two integers is the distance 
        between them on the real number line. For example, the absolute 
        difference of -5 and 5 is 10, and the absolute 
        difference of -5 and -4 is 1.

        You can assume that there will only be one pair of numbers with the smallest difference.
        */
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            var sortedArrayOne = arrayOne.OrderBy(x => x).ToList();
            var sortedArrayTwo = arrayTwo.OrderBy(x => x).ToList();

            var leftIndexPointer = 0;
            var rightIndexPointer = arrayTwo.Length - 1;

            while (leftIndexPointer)

                // Write your code here.
                return new int[] { };
        }
    }
}