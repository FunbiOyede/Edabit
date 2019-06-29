using System;

           

namespace RemoveString
{
   public class Program
    {
    public static void Main(string[] args)
        {
            RemoveFirstLast("Backspace");
      
        }
       public static string RemoveFirstLast(string word)
        {
            string firstLetter = word.Remove(0,1);
            string SecondLetter = firstLetter.Remove(firstLetter.Length - 1);
            string finalString = SecondLetter;

            return finalString;
        }
    }
}
