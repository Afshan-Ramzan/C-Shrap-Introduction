using System;

namespace introduction
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string firstName, lastName;
            Console.WriteLine(" enter your first name :");
            firstName= Console.ReadLine();
            Console.WriteLine(" enter your last name :");
            lastName = Console.ReadLine();
            Console.WriteLine("hello {0} {1}", firstName, lastName);
            Console.WriteLine("Hello "+firstName+" "+lastName); */

            //data types;
            bool b = true;
            float a = 1.23f;
            if (b==true)
            {
                Console.WriteLine("value of a is {0}", a);
            }

            int i = 0;
            Console.WriteLine(int.MaxValue);
            //escape sequences;
            Console.WriteLine("\"");
            //verbatim literal
            string path = @"C:\user\afshan\abc.doc";
            Console.WriteLine(path);
        }
    }
}
