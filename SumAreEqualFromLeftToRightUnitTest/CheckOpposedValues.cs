using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using QuestionTest3;

namespace SumAreEqualFromLeftToRightUnitTest
{
    [TestClass]
    public class CheckOpposedValues
    {
        [TestMethod]
        public void FindSidebySideOfTheArray()
        {
            var input = new List<int> { 1, 2, 3, 4, 5, 7, 8, 10, 12 };
            var result = input.obtainOpposedSide();

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ObtainSidebySideOfEach()
        {
            var input = new List<int> { 1, 4, 5, 6, 8, 10, 17 };
            var result = input.obtainOpposedSide();

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CompareSidebySideTes()
        {
            var input = new List<int> { 12, 56, 5, 6, 7, 9 };
            var result = input.obtainOpposedSide();

            Assert.AreEqual(-1, result);
        }
    }
}

