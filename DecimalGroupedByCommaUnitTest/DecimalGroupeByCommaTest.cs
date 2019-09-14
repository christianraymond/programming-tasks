using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ProgrammingTest;

namespace DecimalGroupedByCommaUnitTest
{
    [TestClass]
    public class DecimalGroupeByCommaTest
    {
        [TestMethod]
        public void InputNumMatchsWithDecimalOutput()
        {
            //Arrange
            var userInputs = new List<int> {1, 10, 100, 1000, 10000, 100000, 1000000, 35235235};
            var result = new List<string>();
            //Act
            var expected = new List<string> {"1", "10", "100", "1,000", "10,000", "100,000", "1,000,000", "35,235,235"};
            //Assert
            userInputs.ForEach(input => { result.Add(input.decimalNumGroupedByCommas()); });
        }
    }
}