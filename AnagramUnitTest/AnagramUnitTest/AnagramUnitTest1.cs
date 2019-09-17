using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using anagramGenerate;
using System.Linq;
using System;

namespace AnagramUnitTest
{
    [TestClass]
    public class AnagramUnitTest1
    {
        [TestMethod]
        public void CompareAnagram()
        {
            //Arrange
            var word = "horse";
            var words = new List<string> { "heros", "shore", "horse"};
            //Act
            var matchingWords = Anagram.FindAnagramWords();

            //Assert
            Assert.AreEqual(matchingWords, words);

        }

    }
}
