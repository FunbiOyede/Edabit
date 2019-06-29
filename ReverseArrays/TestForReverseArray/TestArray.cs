using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseArrays;
namespace TestForReverseArray
{
    [TestClass]
    public class TestArray
    {

        [TestMethod]
        public void TestReverseArray()
        {
            
            int[] numbers = { 23, 45, 66, 246 };
            int[] reverseNumbers = { 246, 66, 45, 23 };


            int[] newArray = ReverseArray.reverseArray(numbers);

            Assert.AreEqual(reverseNumbers, newArray);
        }
    }
}
