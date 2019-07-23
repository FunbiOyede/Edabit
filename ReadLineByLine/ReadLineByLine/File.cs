using System;
using System.IO;
using System.Collections;
namespace ReadLineByLine
{
    class File
    {
        private string FirstOutput, SecondOutput;
       
        private string FirstFilePath = "C:/Users/osho/Documents/Test.txt";
        private string SecondFilePath = "C:/Users/osho/Documents/Sand.txt";
              
        internal void ReadFromFile()
        {
           
            try
            {
                using (StreamReader firstFileReader = new StreamReader(FirstFilePath))
                {
                    using(StreamReader secondFileReader = new StreamReader(SecondFilePath))
                    {

                        while (((FirstOutput = firstFileReader.ReadLine()) != null) && (SecondOutput = secondFileReader.ReadLine()) != null)
                         {

                            Console.WriteLine(FirstOutput + " " + SecondOutput);
                        }
                    }
                  


                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }




    }
}
