using System;

namespace _9_AbstractClasses

{
    class Program : Customer


    {

        public override void print()
        {
            Console.WriteLine("Print Method");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer c = new Program();
            c.print();
        }
    }

    //abstract class are incomplete it is only be used as base class for inheritance.

    public abstract class Customer
    {

        public abstract void print();

    }
    /*
     * difference b/w abstract class and interface
     * abstract class have implementation of some of it methods but interafce class
     * can not have implementation for it methods
     * abstract class have flieds but interface cnt
     * interface class inherit from another interface only
     * but abstract class inherit from interface and another abstract class
     * class inheritance from multiple interface but not from multiple class.
     */
}
