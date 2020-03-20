using System;

namespace _12_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer1 c1 = new Customer();
            //ICustomer2 c2 = new ICustomer2();

            Customer c3 = new Customer();
            c3.print2();
            c1.print1();
        }
    }

    interface ICustomer1
    {
        void print1();
    }
    interface ICustomer2 : ICustomer1
    {
        void print2();

    }

    class Customer : ICustomer2
    {
        public void print1()
        {
            Console.WriteLine("Print1 ");

        }
        public void print2()
        {
            Console.WriteLine("Print2");
        }
    }
}
