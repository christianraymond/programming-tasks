using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions; //Using Regular expression match number with commas.
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ProgrammingTest
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the decimal representation of that number grouped by commas after every 3 digits.
        You can't solve the task using a build-it formating function that can accomplish the whole task on its own.

           Assume: 0 <= n < 1000000000

           1 -> "R 1"
           10 -> "R 10"
           100 -> "R 100"
           1000 -> "R 1,000"
           10000 -> "R 10,000"
           100000 -> "R 100,000"
           1000000 -> "R 1,000,000"
           35235235 -> "R 35,235,235"
      */
    class Question1
    {
        static void Main(string[] args)
        {
           var inputs = new long[] {1, 10, 100, 1000, 10000, 100000, 35235235};
           Console.WriteLine("Welcome to QUestion 1");
           Console.WriteLine("Your inputs are");
           Console.WriteLine();
           foreach (var input in inputs)
            {
            Console.WriteLine(input.ToString("C0"));   //Trying first attempt using .ToString, and hard-coded arraylist   
           }

            /*
             Code here
             */
            /*================================= P:S, Please right click on every single question and select 'Set as Start up Project to run the program, Thanks ============================================== */
            //Let user input values 7 times in the console before printing the result back to them.
            var values = new string[7];
            
            Console.WriteLine();
            Console.WriteLine("Please enter an number, 8 times!");

            for (var item = 0; item < values.Length; item++)
            { 
              values[item] = Console.ReadLine();
            }

            Console.WriteLine("Your formatted numbers are:");
            Console.WriteLine();

            for (var input = 0; input < values.Length; input++)
            {
                /* =======> Trying extra idea to return a string that is in decimal using the commented code below <========= */
                /* var getNumber = values[input];

                 if (getNumber.Length > 3)
                 {
                     var countNum = getNumber.Length;
                     var outputVal = getNumber[countNum - 1];
                 }

                 for (var numbers = getNumber.Length - 1; numbers > +1; numbers--)
                 {
                 } */

                var formattedNumber = values[input];
                Console.WriteLine(formattedNumber + " -> " + "R" + formattedNumber);
               }
            }
        }
    }
