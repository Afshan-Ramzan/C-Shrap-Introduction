using System;

namespace _11_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p1 = new Person(1, "abs");
            p1.Print();
            Person p2 = new Person();
            p2.Id = 2;
            p2.Name = "cvb";
            p2.Print();
            Person p3 = new Person()
            {
                Id = 3,
                Name = "hjk"
            };
            p3.Print();
        }


    }
}

struct Person
{
    private
        int id;
    string name;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }

    public Person(int i, string n)
    {
        this.id = i;
        this.name = n;
    }

    public void Print()
    {
        Console.WriteLine("Id is {0} & Name is {1}", this.id, this.name);
    }
}
