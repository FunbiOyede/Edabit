using System;


namespace ReverseArrays
{
   public class ReverseArray
    {
        
        static void Main(string[] args)
        {

            int[] numbers = { 2, 3, 6, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.WriteLine("array before reversing {0}", i);
            }

            reverseArray(numbers);


        }

        public static void reverseArray(int[] arrayNum)
        {
           
            Array.Reverse(arrayNum);
          
            int[] isReversed = arrayNum;
            foreach (int i in arrayNum)
            {
                Console.WriteLine("array after reversing {0}", i);
            }

        }

    }
}
