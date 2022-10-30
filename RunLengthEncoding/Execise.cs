using System.Text;

namespace CodingExercises.RunLengthEncoding
{
    public class Exercise
    {

        /*
        
        Write a function that takes in a non-empty string and returns its run-length encoding.

        From Wikipedia, "run-length encoding is a form of lossless data compression in which 
        runs of data are stored as a single data value and count, rather than as the original run.
        " For this problem, a run of data is any sequence of consecutive, identical characters. 
        So the run "AAA" would be run-length-encoded as "3A".

        To make things more complicated, however, the input string can contain all 
        sorts of special characters, including numbers. 
        And since encoded data must be decodable, this means 
        that we can't naively run-length-encode long runs. 
        For example, the run "AAAAAAAAAAAA" (12 As), can't naively be encoded as "12A",
        since this string can be decoded as either "AAAAAAAAAAAA" or "1AA". 
        Thus, long runs (runs of 10 or more characters) should be encoded in a split fashion; 
        the aforementioned run should be encoded as "9A3A".
        */
        public static string RunLengthEncoding(string str)
        {
            var output = new StringBuilder();

            char? currentCharacterBeingRecorded = null;
            var characterCount = 0;

            for (var i = 0; i < str.Length; i++)
            {
                var character = str[i];

                // if the character is changing
                if (currentCharacterBeingRecorded != character)
                {
                    // as this isn't the just the first character.
                    if (currentCharacterBeingRecorded != null)
                    {
                        // record this
                        output.Append(characterCount);
                        output.Append(currentCharacterBeingRecorded);

                        // reset for the next series of characters
                        characterCount = 1;
                        currentCharacterBeingRecorded = character;

                    }
                    currentCharacterBeingRecorded = character;
                    characterCount = 1;

                }
                else
                {
                    // if we would hit the upper limit.
                    if (characterCount == 9)
                    {
                        // record this
                        output.Append(characterCount);
                        output.Append(currentCharacterBeingRecorded);

                        // reset for the next series of characters
                        characterCount = 1;
                    }
                    else
                    {
                        // increment the count
                        characterCount = characterCount + 1;
                    }
                }
            }

            // record the last character
            output.Append(characterCount);
            output.Append(currentCharacterBeingRecorded);

            // Write your code here.
            return output.ToString();
        }

    }
}