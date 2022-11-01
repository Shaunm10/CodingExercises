namespace CodingExercises.SpiralTraverse
{
    public class Exercise
    {
        /*
        Write a function that takes in an n x m two-dimensional array (that can be square-shaped when n == m)
        and returns a one-dimensional array of all the array's elements in spiral order.

        Spiral order starts at the top left corner of the two-dimensional array, 
        goes to the right, and proceeds in a spiral pattern all the way 
        until every element has been visited.
        */
        public static List<int> SpiralTraverse(int[,] array)
        {
            var items = new List<int>();
            var processedItems = new List<Point>();
            var xIndex = 0;
            var yIndex = 0;
            var direction = Direction.Left;

            // assuming this is a square 2 dimensioal array.
            var countOfOneSide = array.Length;
            var totalCountOfAllItems = Math.Pow(countOfOneSide, 2);

            for (int i = 0; i < totalCountOfAllItems; i++)
            {
                // get the number at these coordinates and add them to the list.
                var numberAtIndexes = array[xIndex, yIndex];
                items.Add(numberAtIndexes);

                switch (direction)
                {
                    case Direction.Left:

                        // can we keep going left?
                        if (array.Length < yIndex)
                        {

                        }
                        break;

                    case Direction.Down:
                        break;

                    case Direction.Right:
                        break;

                    case Direction.Up:
                        break;
                }
            }

            return items;
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public enum Direction
    {
        Left,
        Down,
        Right,
        Up
    }
}