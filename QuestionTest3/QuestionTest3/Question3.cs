using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTest3
{      /* Requirement..............
             Given a zero-based integer array of lengh N, the equivalence index (i) is the inndex whre the sum of
             all the items to the left of the index are equal to the sum of all the items to the right of the index.

            Constraints: 0 <= N <= 100 000

            Example: Given the following arra [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]
            Your program should ouutput "6" because 1+2+3+4+5+6+7+10+12
            If no index exists then output -1

             */


    /*================================= P:S, Please right click on every single question and select 'Set as Start up Project to run the program, Thanks ============================================== */
    class Question3
    {
        //Code solution goes here
        //Start by creating a static method with two parameters.
        static int GetTheSumOfAnArray(int[] arr, int n)
        {
           Console.WriteLine("Welcome to Question 3 of my challenge!!");
           Console.WriteLine();

            int[] sumIndexVal = new int[n];
            sumIndexVal[0] = arr[0];
            for (int i = 1; i < n; i++)
                sumIndexVal[i] = sumIndexVal[i - 1] +
                               arr[i];

            int[] randomSumVal = new int[n];
            randomSumVal[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
                randomSumVal[i] = randomSumVal[i + 1] +
                               arr[i];

            for (int i = 1; i < n - 1; i++)
                if (sumIndexVal[i] == randomSumVal[i])
                    return arr[i];

            return -1;
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12 };
            int n = arr.Length;
            Console.WriteLine("The sum number is:" + GetTheSumOfAnArray(arr, n));
        }
    }
}

