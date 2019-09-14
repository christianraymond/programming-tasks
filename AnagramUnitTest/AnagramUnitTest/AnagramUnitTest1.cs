using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question2;

namespace AnagramUnitTest
{
    [TestClass]
    public class AnagramUnitTest1
    {
        [TestMethod]
        public void CompareAnagram()
        {
            //Arrange
            var word = "orchestra";
            var words = new List<string> {"orchestra", "heros", "horse", "mist"};
            //Act
            var matchingWords = Anagram.getAllAnagrams(words, word);

            //Assert
            Assert.AreEqual(matchingWords.Count, 3);
        }
    }

    [TestClass]
    public class AnagramUnitTest2
    {
        [TestMethod]
        public void ThisTestWillFail()
        {

            //Arrange
            var word = "notInTheList";
            var words = new List<string> { "accentuate", "accent", "banana", "archicture"};
            //Act
            var matchingWords = Anagram.getAllAnagrams(words, word);

            //Assert
            Assert.AreEqual(matchingWords.Count, 6);
        }
    }
}