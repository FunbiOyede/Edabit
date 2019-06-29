using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseArrays;
namespace TestReversedArray
{
    [TestClass]
    public class TestReverseArray
    {
       private readonly ReverseArray rv = new ReverseArray();
        [TestMethod]
        public void TestMethod1()
        {

            int[] numbers = { 1, 2, 3 };
            int[] reversedNumbers = { 3, 2, 1 };
             int[] newArray = ReverseArray.reverseArray(numbers);
            Assert.AreEqual(newArray, reversedNumbers);
        }
    }
}
