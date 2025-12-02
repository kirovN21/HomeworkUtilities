namespace LetterCountOccurence
{
    internal class LetterCount
    {

        //Create a method that returns the count of occurrence of each letter present in a sentence (case insensitive, A == a).
        static void Main(string[] args)
        {
            CharacterCount("The quick brown, fox jumps over, the lazy dog");
        }

        static void CharacterCount(string sentence)
        {
            string usedSentence = sentence.ToLower().Trim();

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char letter in usedSentence)
            {
                //if(!char.IsLetter(letter))
                //{
                //    continue;
                //}

                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
                else
                {
                    letterCount[letter] = 1;
                }
            }

            foreach (var keyValue in letterCount)
            {
                Console.WriteLine(@$"The character ""{keyValue.Key}"" has occured {keyValue.Value} times.");
            }
        }
    }
}
