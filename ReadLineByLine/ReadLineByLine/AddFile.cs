using System;
using System.IO;
using System.Collections;
namespace ReadLineByLine
{
    class AddFile
    {
        private string FirstFileOutput, SecondOutput;
       
        private string FirstFilePath, SecondFilePath,f1,f2;
        ArrayList array = new ArrayList();


        public void GetText()
        {

            Console.WriteLine("Specify first txt file");
             FirstFilePath = Console.ReadLine();

             

            Console.WriteLine("Specify second txt file path");
            SecondFilePath = Console.ReadLine();


            ReadFromFirstFile(FirstFilePath);
            ReadFromSecondFile(SecondFilePath);


        }


       
        internal void ReadFromFirstFile(string filePath)
        {
           
            try
            {
                using(StreamReader read = new StreamReader(filePath))
                {
                  
                    while ((FirstFileOutput = read.ReadToEnd()) != null)
                    {

                        f1 = FirstFileOutput;

                    }
                   
                }

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        internal void ReadFromSecondFile(string filePath)
        {
           
            try
            {
                using (StreamReader read = new StreamReader(filePath))
                {
                    while ((SecondOutput = read.ReadToEnd()) != null)
                    {
                        f2 = SecondOutput;
                    }
                  

                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }




        public string Concantenate()
        {
            return f1 + " " + f2;
         }
        
    }
}
