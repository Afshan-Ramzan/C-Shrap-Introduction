using System;

namespace _13_ExplicitInterfacecall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            check c = new check();
            ((I2)c).Interafcemethod();

            // default implementation
            c.Interafcemethod();
        }
    }


    interface I1
    {
        void Interafcemethod();

    }

    interface I2
    {
        void Interafcemethod();
    }

    public class check : I1, I2
    {
        //default implementation
        public void Interafcemethod()
        {
            Console.WriteLine("interface 1 method");
        }

        //explicit implementation
        void I2.Interafcemethod()
        {
            Console.WriteLine("interface 2 method");
        }
    }
}
