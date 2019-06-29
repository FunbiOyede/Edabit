using System;

           

namespace RemoveString
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveFirstLast("Backspace");
      
        }
        static string RemoveFirstLast(string word)
        {
            string firstLetter = word.Remove(0,1);
            string SecondLetter = firstLetter.Remove(firstLetter.Length - 1);
            string finalString = SecondLetter;

            return finalString;
        }
    }
}
