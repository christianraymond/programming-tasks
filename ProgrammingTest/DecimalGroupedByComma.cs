using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingTest
{
    public static class DecimalGroupedByComma
        {
            public static void Main(string[] args) { }
            public static string decimalNumGroupedByCommas(this int input)
            {
                var arr = input.ToString().ToCharArray().ToList();
                var convertedVal = String.Empty;

                for (int i = arr.Count - 1; i >= 0; i = i - 3)
                     convertedVal = i < 3 ?
                     $"{arr.itemValues()}{convertedVal}" : $",{arr.getCharSubset(3, string.Empty)}{convertedVal}";
                return convertedVal;
            }
        }
        public static class ListExtension
        {
            /// <param name="charList">List of charactors</param>
            public static string itemValues(this List<char> charList)
            {
                var stringOfDecimal = new StringBuilder();
                charList.ForEach(item => {
                    stringOfDecimal.Append(item);
                });
                return stringOfDecimal.ToString();
            }

            /// Gets a subset from a list, starting from the left, of char and returns it as a string.
            public static string getCharSubset(this List<char> values, int charactorToReturn, string addResultStr)
            {
                if (charactorToReturn == 0)
                    return addResultStr;

                var additionalVal = values[values.Count - 1];
                values.RemoveAt(values.Count - 1);
                return getCharSubset(values, charactorToReturn - 1, addResultStr = $"{additionalVal}{addResultStr}");
            }
      }
}
