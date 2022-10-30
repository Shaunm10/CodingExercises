namespace CodingExercises.ThreeNumberSum
{
    public class Exercise
    {
        /*
        Write a function that takes in a non-empty array of distinct integers 
        and an integer representing a target sum. The function should find all 
        triplets in the array that sum up to the target sum and return a two-dimensional 
        array of all these triplets. The numbers in each triplet should be 
        ordered in ascending order, and the triplets themselves should 
        be ordered in ascending order with respect to the numbers they hold.

        If no three numbers sum up to the target sum, the function should return an empty array.
        */
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            var sortedArray = array.OrderBy(x => x).ToArray();

            var outputArray = new List<int[]>();
            for (var indexA = 0; indexA < sortedArray.Length; indexA++)
            {
                for (var indexB = indexA + 1; indexB < sortedArray.Length; indexB++)
                {
                    for (var indexC = indexB + 1; indexC < sortedArray.Length; indexC++)
                    {
                        var numA = sortedArray[indexA];
                        var numB = sortedArray[indexB];
                        var numC = sortedArray[indexC];
                        if (numA + numB + numC == targetSum)
                        {
                            outputArray.Add(new int[] { numA, numB, numC });
                        }
                    }
                }
            }

            // now sort.
            return outputArray;
        }
    }
}