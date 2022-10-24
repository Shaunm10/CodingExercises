namespace CodingExercises.ProductSum
{
    public class Exercise
    {
        /*
        Write a function that takes in a "special" array and returns its product sum.

        A "special" array is a non-empty array that contains either integers or other "special" arrays. 
        The product sum of a "special" array is the sum of its elements, where "special" arrays inside it 
        are summed themselves and then multiplied by their level of depth.

        The depth of a "special" array is how far nested it is. 
        For instance, the depth of [] is 1; the depth of the inner array in [[]] is 2; the depth of the innermost array in [[[]]] is 3.

        Therefore, the product sum of [x, y] is x + y; the product sum of [x, [y, z]] is x + 2 * (y + z); 
        the product sum of [x, [y, [z]]] is x + 2 * (y + 3z).
        */
        public static int ProductSum(List<object> array)
        {
            var sum = 0;
            var nextDeptLevel = 2;

            for (var i = 0; i < array.Count; i++)
            {
                var itemAtIndex = array[i];

                if (itemAtIndex is int)
                {
                    sum = sum + (int)itemAtIndex;
                }
                else
                {
                    var additionalLevels = ProductSum((List<object>)itemAtIndex, nextDeptLevel);
                    additionalLevels.ForEach(x => 
                    {
                        sum = sum + (x.Level * x.Sum);
                    });
                }
            }


            return sum;
        }

        public static List<(int Level, int Sum)> ProductSum(List<object> array, int arrayLevel)
        {
            var levels = new List<(int Level, int Sum)>();
            var sum = 0;

            for (var i = 0; i < array.Count; i++)
            {
                var itemAtIndex = array[i];

                if (itemAtIndex is int)
                {
                    sum = sum + (int)itemAtIndex;
                }
                else
                {
                    levels.AddRange(ProductSum((List<object>)itemAtIndex, arrayLevel + 1));
                    //sum = sum + arrayLevel * ProductSum((List<object>)itemAtIndex, arrayLevel + 1);
                }
            }
            levels.Add(new (arrayLevel, sum));
            return levels;
        }
    }
}