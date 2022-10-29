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
            for (var i = 0; i < str.Length; i++)
            {
                var character = str[i];
                var shiftedCharacter = ShiftCharacter(character, key);
                characters[i] = shiftedCharacter;
            }

            return characters.ToString();
        }

        private static char ShiftCharacter(char character, int key)
        {
            const int alphabeticCharStart = 97;

            var charAsByte = Convert.ToByte(character);

            var convertedByte = charAsByte + key;

            if (convertedByte > alphabeticCharStart + 26)
            {
                convertedByte = convertedByte + alphabeticCharStart - 26;
            }

            var returnChar = Convert.ToChar(convertedByte);

            return returnChar;
        }
    }
}