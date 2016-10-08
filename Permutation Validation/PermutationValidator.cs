using System.Collections.Generic;

namespace Permutation_Validation
{
    public static class PermutationValidator
    {
        public static bool IsValidPermutation(string wordOne, string wordTwo)
        {
            Dictionary<char, int> mapOne = BuildMap(wordOne);
            Dictionary<char, int> mapTwo = BuildMap(wordTwo);
            return AreEqual(mapOne, mapTwo);
        }

        private static Dictionary<char, int> BuildMap(string word)
        {
            var map = new Dictionary<char, int>();

            // Guard against null or empty strings.
            if (string.IsNullOrEmpty(word)) return map;

            // Loop through each character in the string.
            foreach (var c in word.ToCharArray())
            {
                // If the character is already in the dictionary (hashmap), increment its count.
                int val;
                if (map.TryGetValue(c, out val))
                {
                    map[c] = val + 1;
                }
                // Otherwise, record the first occurence of this character.
                else map.Add(c, 1);
            }

            return map;
        }

        private static bool AreEqual(Dictionary<char, int> mapOne, Dictionary<char, int> mapTwo)
        {
            // If the words contain a different set of characters, they are not permutations.
            if (mapOne.Count != mapTwo.Count) return false;

            foreach (var keyValuePair in mapOne)
            {
                // If the character is not in both hashmaps, the words are not permutations.
                if (!mapTwo.ContainsKey(keyValuePair.Key)) return false;

                // If the character occurs a different number of times, the words are not permutations.
                if (keyValuePair.Value != mapTwo[keyValuePair.Key]) return false;
            }

            return true;
        }
    }
}
