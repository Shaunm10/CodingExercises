namespace CodingExercises.FirstNonRepeatingCharacter
{
    public class Exercise
    {
        /*
        Write a function that takes in a string 
        of lowercase English-alphabet letters and returns the index 
        of the string's first non-repeating character.

        The first non-repeating character is the first character 
        in a string that occurs only once.

        If the input string doesn't have any non-repeating characters, 
        your function should return -1
        */
        public static int FirstNonRepeatingCharacterLinq(string str)
        {
            // Write your code here.
            var nonRepeatCharacterByFirstIndex = str
                .GroupBy(x => x) // group it so we can get the count
                .Where(x => x.Count() == 1) // filter out all the duplicates
                .Select(x => x.Key) //  get the characters
                .Select(c => new
                {
                    character = c,
                    FirstIndexOf = str.IndexOf(c)
                });

            // in the case where are only repeated letters in the input.
            if (!nonRepeatCharacterByFirstIndex.Any())
            {
                return -1;
            }

            var minIndex = nonRepeatCharacterByFirstIndex.Min(x => x.FirstIndexOf);

            var candidate = nonRepeatCharacterByFirstIndex
            .FirstOrDefault(x => x.FirstIndexOf == minIndex)?
            .FirstIndexOf;

            return candidate.HasValue ? candidate.Value : -1;
        }

        public static int FirstNonRepeatingCharacter(string str)
        {
            var letterCounts = new Dictionary<char, CharacterByIndex>();
            for (var i = 0; i < str.Length; i++)
            {
                var character = str[i];

                if (letterCounts.Keys.Contains(character))
                {
                    // than we need to update it's count
                    letterCounts[character].Count += 1;
                }
                else
                {
                    // than we need to add it and record it's index
                    letterCounts[character] = new CharacterByIndex
                    {
                        Count = 1,
                        FirstIndex = i
                    };
                }
            }

            var minIndex = int.MaxValue;
            foreach (var key in letterCounts.Keys)
            {
                var letterCount = letterCounts[key];
                if (letterCount.Count == 1)
                {
                    if (letterCount.FirstIndex < minIndex)
                    {
                        minIndex = letterCount.FirstIndex;
                    }
                }
            }

            if (minIndex == int.MaxValue)
            {
                return -1;
            }

            return minIndex;

        }
    }

    internal class CharacterByIndex
    {
        //public char Character { get; set; }
        public int Count { get; set; }
        public int FirstIndex { get; set; }
    }
}