using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    class Qestion2
    {
        /* Requirement..........
         Devise a function that gets one word as a parameter and returns all the anagrams for it fromthe file wordlist.text.

        "Anagram": An anagram is a trype of word play, the result of rearranging the letter of a word or phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be reacrranged into carthorse.

        You can not usr permutations to generate the possible words.

        anagrams("horse") should return:
        ['heros', 'horse', 'shore'] 
         */


  /*================================= P:S, Please right click on every single question and select 'Set as Start up Project to run the program, Thanks ============================================== */
        class program
        {
           /*
             Code goes here :)
            */

            // Start by creating a file words.txt in workspace folder.(In my computer).
            //You can manually create a .text file in your local machine and pass some words in there to manupulate this program.

            private static int AnagramWordParameterFunc(string str)
            {
                char[] foo = str.ToArray();
                Array.Sort(foo);
                return new string(foo).GetHashCode();
            }

            private static void Main(string[] args)
            {
                var s1 = Stopwatch.StartNew();
               
                StreamReader sr = new StreamReader(@"C:\workspace\words.text"); //This file will need to be available in your local computer.
                string[] wordlist = sr.ReadToEnd().Split("\r\n".ToCharArray());
                int[] hashes = new int[wordlist.Count()];

                for (int i = 0; i <= wordlist.GetUpperBound(0); i++)
                {
                    hashes[i] = AnagramWordParameterFunc(wordlist[i]);
                }

                s1.Stop();
                Console.WriteLine("Words loaded in: " + s1.Elapsed.TotalMilliseconds + " ms");
                Console.WriteLine("Words anagrams for (" + wordlist.Count() + " words loaded): ");

                string newWord;

                do
                {
                    newWord = Console.ReadLine();

                    if (newWord != null)
                    {
                        s1.Reset();
                        s1.Start();
                        newWord = newWord.ToLower();
                        StringBuilder output = new StringBuilder();
                        int w1hash = AnagramWordParameterFunc(newWord);
                        Console.WriteLine("Anagrams for " + newWord + ":");

                        for (int x = 0; x <= hashes.GetUpperBound(0); x++)
                        {
                            if (hashes[x] == w1hash && wordlist[x] != newWord)
                            {
                                output.AppendLine(wordlist[x]);
                            }
                        }

                        s1.Stop();
                        Console.Write(output.ToString());
                        Console.WriteLine("Anagrams output found in: " + s1.Elapsed.TotalMilliseconds + " ms");
                    }
                } while (newWord != null);
            }
        }
    }
}
       
