namespace CodingExercises.FindThreeLargestNumbers
{
    /*

    Write a function that takes in an array of at least three integers and, 
    without sorting the input array, returns a sorted array of the three 
    largest integers in the input array.

    The function should return duplicate integers if necessary; for example, 
    it should return [10, 10, 12] for an input array of [10, 5, 9, 10, 12].

    */
    public class Exercise
    {
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            var topThreeLargest = array
                .ToList()
                .OrderByDescending(x => x)
                .Take(3);

            return topThreeLargest.OrderBy(x => x).ToArray();
        }
    }
}