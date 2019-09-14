using System.Collections.Generic;

namespace QuestionTest3
{
    public static class SumAreEqualFromLeftToRight
    {
        public static void Main(string[] args) { }
        /// Returns the first equivalence point found from a list of integers. If none was found then it will return -1.
        public static int obtainOpposedSide(this List<int> numbers)
        {
            if (numbers.Count == 0)
                return -1;

            return oppositionBalanceState(numbers, getSum(numbers) - numbers[0], 0, 1);
        }

        /// Now calculate the OppositionValueList.
        private static int oppositionBalanceState(List<int> numbers, int leftAmount, int rightAmount, int currentVal)
        {
            if (rightAmount == leftAmount)
                return currentVal - 1;
            else if (rightAmount > leftAmount)
                return -1;
            else
                return oppositionBalanceState(numbers, leftAmount - numbers[currentVal],
                    getSumFromRight(numbers, currentVal), currentVal + 1);
        }

        ///Next is to calculates the sum of the right hand side.
        private static int getSumFromRight(List<int> numbers, int countFromRight)
        {
            var total = 0;
            for (int i = 0; i < countFromRight; i++)
                total += numbers[i];

            return total;
        }
        /// Used to calculate the sum from a list of integers.
        private static int getSum(List<int> numbers)
        {
            var result = 0;
            numbers.ForEach(number => {
                result += number;
            });

            return result;
        }
    }
}
