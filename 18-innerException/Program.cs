using System;
using System.IO;

namespace _18_innerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First number ");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second number ");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int result = FN / SN;
                    Console.WriteLine("Result of division is {0}", result);
                }
                catch (Exception ex)
                {
                    string filepath = @"C\log.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem , please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + " is not present",ex);

                    }
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine("Current Exception = {0}", excep.GetType().Name);
                if (excep.InnerException != null)
                {
                    Console.WriteLine("inner Exception = {0}", excep.InnerException.GetType().Name);
                }
            }
        }
    }
}
