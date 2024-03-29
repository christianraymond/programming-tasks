﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

//Right click on the Question folder(eg: Question3)then select #Set as a StartUp Project# to run the app. because there are more than one project in the same solution.

namespace anagramGenerate //Hit Ctrl + F5 to execute the program in cdm.
{
    public static class Program
    { 
        public static IEnumerable<string> FindAnagramWords()
        {
            using (StreamReader sr = File.OpenText("C:/workspace/ProgrammingTest/wordlist.txt"))  //Give the right path to this file in your computer.
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Length > 0)
                    {
                        yield return s;
                    }
                }
            }
        }

        static Char[] ToCharArray(string Source)
        {
            char[] CharArray = Source.ToLower().ToCharArray();
            Array.Sort(CharArray);
            return CharArray;
        }

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Dictionary<Char[], List<string>> AllWords =
                new Dictionary<Char[], List<string>>(new CompareArrayOfCharactor());
            foreach (string word in FindAnagramWords())
            {
                List<string> WordList;
                Char[] key = ToCharArray(word);
                if (!AllWords.TryGetValue(key, out WordList))
                {
                    WordList = new List<string>();
                    AllWords.Add(key, WordList);
                }

                WordList.Add(word);
            }

            string CompareWord;
            do
            {
                Console.Write(string.Format("{0}Type the word you would like to see the anagram for: ", Environment.NewLine));
                CompareWord = Console.ReadLine();

                stopWatch.Reset();
                stopWatch.Start();
              if (CompareWord != null)
                {
                    IEnumerable<string> Anagrams = new List<string>();
                    try
                    {
                       Anagrams = AllWords[ToCharArray(CompareWord)];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Oops, the word you typed does not exist in the list, please try again!");
                        continue;
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Anagram for " + CompareWord + " are:");

                    foreach (string word in Anagrams)
                    {
                        Console.WriteLine(word);
                    }
                }
              
            } while (CompareWord != null);
        }
    }

    internal class CompareArrayOfCharactor : EqualityComparer<Char[]>
    {
        private static readonly EqualityComparer<Char> Comparer = EqualityComparer<Char>.Default;

        public override bool Equals(char[] x, char[] y)
        {
            if (x == null) return false;
            if (y == null) return false;

            if (x.Length != y.Length)
            {
                return false;
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (!Comparer.Equals(x[i], y[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode(char[] obj)
        {
            unchecked
            {
                if (obj == null) return 0;
                int hash = 22;
                foreach (char Item in obj)
                {
                    hash = (((hash << 5) - hash) ^ Comparer.GetHashCode(Item));
                }

                return hash;
            }

        }
    }
}