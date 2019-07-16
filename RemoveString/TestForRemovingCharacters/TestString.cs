using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveString;

namespace TestForRemovingCharacters
{
    [TestClass]
    public class TestString
    {
        [TestMethod]
        public void Test()
        {
            string word = "Balance";
            string FirstAndSecondLetter = "alanc";
            string finalWord = Program.RemoveFirstLast(word);

            Assert.AreEqual(finalWord, FirstAndSecondLetter);
        }
    }
}
