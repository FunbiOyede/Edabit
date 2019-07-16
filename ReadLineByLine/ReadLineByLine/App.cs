using System;

namespace ReadLineByLine
{
    class App
    {
      static  AddFile readFiles = new AddFile();
        public static void Main(string[] args)
        {

            readFiles.GetText();
            ReadFromFiles();
            Console.WriteLine("Concantenated values are");
            var concatValue = readFiles.Concantenate();
            Console.WriteLine(concatValue);
        }


        public static void ReadFromFiles()
        {
            readFiles.ReadFromFirstFile();
            readFiles.ReadFromSecondFile();
            
        }
    }

}
