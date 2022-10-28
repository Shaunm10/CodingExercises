namespace CodingExercises.PalindromeCheck
{
    public class Exercise
    {
        public static bool IsPalindrome(string str)
        {
            for (var frontIndex = 0; frontIndex < str.Length; frontIndex++)
            {
                var backIndex = (str.Length - 1) - frontIndex;

                // see if the characters from the different sides are identical
                if (str.ElementAt(frontIndex) != str.ElementAt(backIndex))
                {
                    // if these are not the same than we don't have a palindrome
                    return false;
                }

                // if the indexes are passing each other.
                if (frontIndex >= backIndex)
                {
                    return true;
                }
            }

            return false;
        }
    }
}