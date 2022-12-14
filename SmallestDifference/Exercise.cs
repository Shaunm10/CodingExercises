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
            var rightIndexPointer = 0;

            var answer = new int[] { };
            var differenceCandidate = int.MaxValue;

            // while the pointers aren't at the other end of their arrays.
            while (leftIndexPointer < sortedArrayOne.Count &&
                rightIndexPointer < sortedArrayTwo.Count)
            {
                var leftNumber = sortedArrayOne[leftIndexPointer];
                var rightNumber = sortedArrayTwo[rightIndexPointer];

                var difference = leftNumber - rightNumber;

                // if the candidate is NULL or the difference is less than
                // the old candidate.
                if (Math.Abs(difference) < Math.Abs(differenceCandidate))
                {
                    answer = new int[] { leftNumber, rightNumber };
                    differenceCandidate = difference;
                }

                if (leftNumber > rightNumber)
                {
                    rightIndexPointer++;
                }

                if (leftNumber < rightNumber)
                {
                    leftIndexPointer++;
                }
            }
            // finally return the 2 numbers
            return answer;
        }
    }
}