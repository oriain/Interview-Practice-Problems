using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutation_Validation
{
    public static class PermutationValidator
    {
        public static bool IsValidPermutation(string wordOne, string wordTwo)
        {
            #region First implementation
            //Dictionary<char, int> mapOne = BuildMap(wordOne);
            //Dictionary<char, int> mapTwo = BuildMap(wordTwo);
            //return AreEqual(mapOne, mapTwo);
            #endregion

            // Guard against nulls
            wordOne = wordOne ?? string.Empty;
            wordTwo = wordTwo ?? string.Empty;

            // If words are not the same length, they are not permutations.
            if (wordOne.Length != wordTwo.Length) return false;

            // Add up the numeric value of each word.  They should be the same for permutations.
            int totalOne = wordOne.Sum(c => c ^ 2);
            int totalTwo = wordTwo.Sum(c => c ^ 2);
            return totalOne == totalTwo;
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
                char c = keyValuePair.Key;

                // If the character is not in both hashmaps, the words are not permutations.
                if (!mapTwo.ContainsKey(c)) return false;

                // If the character occurs a different number of times, the words are not permutations.
                if (mapTwo[c] != keyValuePair.Value) return false;
            }

            return true;
        }
    }
}
