using System;
using System.IO;

namespace ReadLineByLine
{
    class AddFile
    {
        private string text, text2, firstFileOutput, secondFileOutput;
        internal string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

        public void GetText()
        {
            Console.WriteLine("Add to first file");
             text = Console.ReadLine();
            writeToFirstFile(text);

            Console.WriteLine("Add to second file");
            text2 = Console.ReadLine();
             writeToSecondFile(text2);


        }


        protected void writeToFirstFile(string textInput)
        {
            


            using (StreamWriter writer = new StreamWriter(Path.Combine(filePath, "FirstFile.txt")))
            {

                writer.WriteLine(textInput);
            }
            


        }


        protected void writeToSecondFile(string _textInput)
        {

            using (StreamWriter writer = new StreamWriter(Path.Combine(filePath, "Secondfile.txt")))
            {
                writer.WriteLine(_textInput);
            }
               
        }
        internal void ReadFromFirstFile()
        {
           
            try
            {
                using(StreamReader read = new StreamReader("FirstFile.txt"))
                {
                    firstFileOutput =  read.ReadLine();
                   
                }

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        internal void ReadFromSecondFile()
        {
            try
            {
                using (StreamReader read = new StreamReader("SecondFile.txt"))
                {
                    secondFileOutput = read.ReadLine();
                  
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public string Concantenate()
        {
            return firstFileOutput + " " + secondFileOutput;
        }
        
    }
}
