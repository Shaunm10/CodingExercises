namespace CodingExercises.CaesarCipherEncryptor
{
    public class Exercise
    {
        /*
        Given a non-empty string of lowercase letters and a non-negative integer representing a key, 
        write a function that returns a new string obtained by shifting every letter in the input string by k positions in the alphabet, where k is the key.

        Note that letters should "wrap" around the alphabet; in other words, the letter z shifted by one returns the letter a.
        */
        public static string CaesarCypherEncryptor(string str, int key)
        {
            var characters = new char[str.Length];
            for (var i = 1; i < str.Length; i++)
            {
                var newIndex = CalculateNewIndex(i, key, str.Length);
                var character = str[i];
                characters[newIndex] = character;
            }

            return characters.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialIndex">Where the index starts from</param>
        /// <param name="key">How many Chars to move to the right.</param>
        /// <param name="totalLength">What the total capacity is of the string.</param>
        /// <returns></returns>
        private static int CalculateNewIndex(int initialIndex, int key, int totalLength)
        {
            if (initialIndex + key > totalLength)
            {
                return initialIndex + key;
            }

            return (initialIndex + key) % totalLength;

        }
    }
}