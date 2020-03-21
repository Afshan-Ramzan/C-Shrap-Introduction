using System;

//type
//public class Customer
//{
//    //type members
//    private
//        int _id;
//    string _name;
//    public
//        int Id { get; set; }
//        string Name { get; set; }
//    public
//        void print_name()
//    {
//        Console.WriteLine("your name is {0}", _name);
//    }

//}

public class Customer
{
    protected int ID;
}

public class CoperatorCustomer : Customer
{
    public void printID()
    {
        // derived class access protected member
        CoperatorCustomer cc = new CoperatorCustomer();
        cc.ID = 123;
        base.ID = 00;
        this.ID = 987;
    }
}

namespace _23_Access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            //Console.WriteLine(c1._id);
            Console.WriteLine("Hello World!");
        }
    }
}
