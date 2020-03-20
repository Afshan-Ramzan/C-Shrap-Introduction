using System;

namespace _8_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer("afshan", "ramzan");
            //c1.Print();
            //Customer c2 = new Customer();
            //c2.Print();

            Circle c1 = new Circle(2);
            float area = c1.CalculateArea();
            Console.WriteLine("area of circle is {0}", area);
            Console.WriteLine("value of pie is {0}", Circle.Pie());
        }
    }
}
class Circle
{
    private
        float radius;
    static float PI;

    static Circle()
    {
        Circle.PI = 3.14F;
        Console.WriteLine("static constructure");
    }
    public static float Pie()
    {
        return Circle.PI;
    }
    public Circle(float r)
    {
        this.radius = r;

    }
    public float CalculateArea()
    {
        return Circle.PI * this.radius * this.radius;
    }
}
class Customer
{
    private string Fname;
    private string Lname;


    // constructure overloading... 
    public Customer() : this("No First Name provided", "No Last Name Provided")
    {

    }
    public Customer(string FN, string LN)
    {
        this.Fname = FN;
        this.Lname = LN;
    }

    public void Print()
    {
        Console.WriteLine("Customer full name is {0} {1}", this.Fname, this.Lname);
    }
    ~Customer()
    {

    }
}
