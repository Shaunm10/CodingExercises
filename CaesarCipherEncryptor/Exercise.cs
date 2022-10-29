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

            return new string(characters);
        }

        private static char ShiftCharacter(char character, int key)
        {
            // the alphabetic charaters run from 97 -> 122
            const int alphabeticCharStart = 96;
            const int NumberOfCharactersInAlphabet = 26;

            // normalize the key, so it's in bounds
            if (key > NumberOfCharactersInAlphabet)
            {
                key = key % NumberOfCharactersInAlphabet;
            }

            var charAsByte = Convert.ToByte(character);

            var convertedByte = charAsByte + key;

            if (convertedByte > alphabeticCharStart + NumberOfCharactersInAlphabet)
            {
                convertedByte = convertedByte - NumberOfCharactersInAlphabet;
            }

            var returnChar = Convert.ToChar(convertedByte);

            return returnChar;
        }
    }
}