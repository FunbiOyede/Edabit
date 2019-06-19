using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringComparson
{
   public class Compare
    {
        static void Main(string[] args)
        {
            CompareString("Love", "Happy");
        }

        public static bool CompareString(string firstValue, string SecondValue)
        {

            int ValueOne = firstValue.Length;
            int ValueTwo = SecondValue.Length;

            if (ValueOne != ValueTwo)
                return false;
            else
                return true;

        }
    }
}
