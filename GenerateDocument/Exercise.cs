namespace CodingExercises.GenerateDocument
{
    public class Exercise
    {
        /*
        You're given a string of available characters and a string representing 
        a document that you need to generate. Write a function that 
        determines if you can generate the document using the available characters. 
        If you can generate the document, your function should return true; 
        otherwise, it should return false.

        You're only able to generate the document if the frequency of unique 
        characters in the characters string is greater than or equal to the 
        frequency of unique characters in the document string. For example, 
        if you're given characters = "abcabc" and document = "aabbccc" 
        you cannot generate the document because you're missing one c.

        The document that you need to create may contain any characters, 
        including special characters, capital letters, numbers, and spaces.

        Note: you can always generate the empty string ("").
        */
        public static bool GenerateDocument(string characters, string document)
        {
            var characterLookUp = new Dictionary<char, int>();
            var documentLookUp = new Dictionary<char, int>();
            var hasEnoughCharacters = true;

            // convert the characters to the dictionary
            for (var i = 0; i < characters.Length; i++)
            {
                var character = characters[i];

                if (!characterLookUp.Keys.Contains(character))
                {
                    characterLookUp[character] = 1;
                }
                else
                {
                    characterLookUp[character] = characterLookUp[character] + 1;
                }
            }

            // convert the characters to the dictionary
            for (var i = 0; i < document.Length; i++)
            {
                var character = document[i];

                if (!documentLookUp.Keys.Contains(character))
                {
                    documentLookUp[character] = 1;
                }
                else
                {
                    documentLookUp[character] = documentLookUp[character] + 1;
                }
            }

            documentLookUp.Keys.ToList().ForEach(c =>
            {
                var requiredCount = documentLookUp[c];

                if (!characterLookUp.Keys.Contains(c) ||
                    characterLookUp[c] < requiredCount)
                {
                    hasEnoughCharacters = false;
                }
            });

            return hasEnoughCharacters;
        }
    }
}