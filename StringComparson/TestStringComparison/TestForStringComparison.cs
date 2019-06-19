using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringComparson;

namespace TestStringComparison
{
    [TestClass]
    public class TestForStringComparison
    {

      

        [TestMethod]

        public void TestForStringComparisonTrue()
        {
            string str1 = "FOLLY";
            string str2 = "QUITS";
            bool strBool = Compare.CompareString(str1, str2);
            bool strValue = true;
            Assert.AreEqual(strBool, strValue);
        }

        [TestMethod]
        public void TestForStringComparisonNegative()
        {
            string string1 = "happy";
            string string2 = "sad";

            bool BoolString = Compare.CompareString(string1, string2);
            bool ValueString = false;
            Assert.AreEqual(BoolString, ValueString);
        }
    }
}
