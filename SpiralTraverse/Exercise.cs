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
            var direction = Direction.Right;
            
            for (int i = 0; i < array.Length; i++)
            {
                // get the number at these coordinates and add them to the list.
                var numberAtIndexes = array[yIndex, xIndex];
                items.Add(numberAtIndexes);

                // record this space
                processedItems.Add(new Point { X = xIndex, Y = yIndex });

                switch (direction)
                {
                    case Direction.Left:
                        if (IsHittingBarrier(array, processedItems, xIndex - 1, yIndex))
                        {
                            // change direction
                            direction = Direction.Up;
                            yIndex--;
                        }
                        else
                        {
                            xIndex--;
                        }

                        break;

                    case Direction.Down:
                        // can we keep going down?
                        if (IsHittingBarrier(array, processedItems, xIndex, yIndex + 1))
                        {
                            // change direction
                            xIndex--;
                            direction = Direction.Left;
                        }
                        else
                        {
                            yIndex++;
                        }
                        break;

                    case Direction.Right:
                        // can we keep going right?
                        if (IsHittingBarrier(array, processedItems, xIndex + 1, yIndex))
                        {
                            // change direction
                            yIndex++;
                            direction = Direction.Down;
                        }
                        else
                        {
                            // keep going right.
                            xIndex++;
                        }
                        break;

                    case Direction.Up:

                        // can we keep going Up?
                        if (IsHittingBarrier(array, processedItems, xIndex, yIndex - 1))
                        {
                            // change direction
                            xIndex++;
                            direction = Direction.Right;
                        }
                        else
                        {
                            yIndex--;
                        }
                        break;
                }
            }

            return items;
        }

        private static bool IsHittingBarrier(int[,] array, List<Point> processedItems, int xIndex, int yIndex)
        {
            // check to see if either value is too large, and are outside the range of the index.
            if (array.GetLength(0) <= yIndex || array.GetLength(1) <= xIndex)
            {
                return true;
            }

            // see if either value is too small, and are outside the range of the index.
            if (yIndex < 0 || xIndex < 0)
            {
                return true;
            }

            if (processedItems.Any(p => p.X == xIndex && p.Y == yIndex))
            {
                return true;
            }
            return false;
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