using System;

namespace RBG_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Random randomNumber = new Random();
            var RedNumber = randomNumber.Next(256);
            var BlueNumber = randomNumber.Next(256);
            var GreenNumber = randomNumber.Next(256);

            Console.WriteLine("color:  rgb({0},{1},{2})",RedNumber,BlueNumber,GreenNumber);
        }


        
    }
}
