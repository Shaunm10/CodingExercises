namespace CodingExercises.ArrayOfProducts
{
    public class Exercise
    {
        /*
        Write a function that takes in a non-empty array of integers
         and returns an array of the same length, where each element 
         in the output array is equal to the product of every other 
         number in the input array.

        In other words, the value at output[i] is equal to the 
        product of every number in the input array other than input[i].

        Note that you're expected to solve this problem without 
        using division.
        */
        public static int[] ArrayOfProductsLinq(int[] array)
        {
            // Write your code here.
            return array
            .ToList()
            .Select(x => array
                .Where(z => z != x)
                .Aggregate((acc, val) => acc * val))
                .ToArray();
        }

        public static int[] ArrayOfProducts(int[] array)
        {

            for (var i = 0; i < array.Length; i++)
            {
                var allNumbersExcept = array.w

            }
        }
    }
}