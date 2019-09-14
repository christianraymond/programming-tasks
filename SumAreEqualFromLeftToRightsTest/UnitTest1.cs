using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using QuestionTest3;

namespace SumAreEqualFromLeftToRightsTest
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void CheckEquilibrium1()
            {
                var input = new List<int> { 1, 2, 3, 4, 5, 7, 8, 10, 12 };
                var result = input.getEquilibrium();

                Assert.AreEqual(6, result);
            }

            [TestMethod]
            public void CheckEquilibrium2()
            {
                var input = new List<int> { 1, 4, 5, 6, 8, 10, 17 };
                var result = input.getEquilibrium();

                Assert.AreEqual(-1, result);
            }

            [TestMethod]
            public void CheckEquilibrium3()
            {
                var input = new List<int> { 12, 56, 5, 6, 7, 9 };
                var result = input.getEquilibrium();

                Assert.AreEqual(-1, result);
            }
       }
    }

