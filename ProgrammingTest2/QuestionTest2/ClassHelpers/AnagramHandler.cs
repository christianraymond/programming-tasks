using System.Collections.Generic;
using System.Linq;

namespace Question2.Helpers
{
    public static class AnagramHandler
     {
            /// Returns the result of the anagram check.
            public static bool isAnagram(this string word, string wordInQuestion)
            {
                return word.Length != wordInQuestion.Length ? false : anagramCheck(word.ToCharArray().ToList(), wordInQuestion, word.Length);
            }
            /// This is used to check if a word, in comparison to another word, are anagrams of each other.
            private static bool anagramCheck(List<char> word, string wordInQuestion, int curr)
            {
                if (curr == 0)
                    return true;

                if (wordInQuestion.ToLower().Contains(word[curr - 1].ToString().ToLower()))
                    return anagramCheck(word, wordInQuestion, curr - 1);
                else
                    return false;
            }
       }
 }
