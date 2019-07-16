using System;

namespace ReadLineByLine
{
    class App
    {
      static  AddFile readFiles = new AddFile();
        public static void Main(string[] args)
        {

            readFiles.GetText();
            Console.WriteLine(readFiles.Concantenate()); 
        }


        
    }

}
