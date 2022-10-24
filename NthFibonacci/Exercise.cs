namespace CodingExercises.NthFibonacci
{
    public class Exercise
    {
        /*
        The Fibonacci sequence is defined as follows: the first number of the sequence is 0, 
        the second number is 1, and the nth number is the sum of the (n - 1)th and (n - 2)th numbers. 
        Write a function that takes in an integer n and returns the nth Fibonacci number.

        Important note: the Fibonacci sequence is often defined with its first two numbers as
        F0 = 0 and F1 = 1. For the purpose of this question, the first Fibonacci number is F0; therefore,
        getNthFib(1) is equal to F0, getNthFib(2) is equal to F1, etc..
        */

        public static int GetNthFib(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            if (n == 2)
            {
                return 1;
            }

            var num1Before = n - 1;
            var num2Before = n - 2;
            var num1BeforeFib = GetNthFib(num1Before);
            var num2BeforeFib = GetNthFib(num2Before);

            return num1BeforeFib + num2BeforeFib;
        }
    }
}