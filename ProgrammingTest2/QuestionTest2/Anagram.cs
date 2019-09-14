using Question2.Helpers;
using System.Collections.Generic;
using System.IO;

namespace Question2
{
    public static class Anagram
    {
        public static void Main(string[] args) { }
            /// Returns all the anagrams form a list of string given an input word.
            public static List<string> getAllAnagrams(List<string> anagramBase, string word)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory().ToString(), "wordlist.txt");
                var words = path.readFile();

                var input = "orchester";
                var anagramsFound = getAllAnagrams(words, input);

                var matches = new List<string>();
                anagramBase.ForEach(anagram =>
                {
                    if (word.isAnagram(anagram))
                        matches.Add(anagram);
                });
                return matches;
            }
        }
}

/*Please see more code refference for this file inside *ClassHelper* Folder */