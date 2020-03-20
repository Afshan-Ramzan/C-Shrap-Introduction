using System;

namespace _14_UsingMultipleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AB ab = new AB();
            ab.Amethod();
        }
    }
}
interface IA
{
    void Amethod();
}
interface IB
{
    void Bmethod();
}

public class A : IA
{
    public void Amethod()
    {
        Console.WriteLine("A");

    }

}

public class B : IB
{
    public void Bmethod()
    {
        Console.WriteLine("B");
    }

}

public class AB : IA, IB
{
    A a = new A();
    B b = new B();
    public void Amethod()
    {
        a.Amethod();
    }
    public void Bmethod()
    {
        b.Bmethod();
    }
}
