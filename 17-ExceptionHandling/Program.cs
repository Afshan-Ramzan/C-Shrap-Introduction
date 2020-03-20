using System;
using System.IO;

namespace _17_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader=null;
            try
            {
                reader = new StreamReader(@"E:\sample\files.txt");
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} ",ex.FileName);
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex) //general exception at bottom catch ...it its the practical example
            //of inheritance, Exception is base class and File not found is special class
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                Console.WriteLine("finally block excute.");
            }
        }
    }
}
