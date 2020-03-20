using System;

namespace _10_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //FullTimeEmployee FTE = new FullTimeEmployee(120000, "afshan", "ramzan", "afshan@hotmail.com");
            //FTE.PrintFullNAme();
            ////PartTimeEmployee PTE = new PartTimeEmployee(120000, "ayesha", "ramzan", "afshan@hotmail.com");
            //// PTE.PrintFullNAme();
            //// ((Employee)PTE).PrintFullNAme();

            //Employee PTE = new PartTimeEmployee(120000, "ayesha", "ramzan", "afshan@hotmail.com");
            //PTE.PrintFullNAme();


            //Employee[] emp = new Employee[3];
            //emp[0] = new Employee("afshan", "ramzan", "afshan@hotmail.com");
            //emp[1] = new PartTimeEmployee(120000, "ayesha", "ramzan", "ayesha@hotmail.com");
            //emp[2] = new FullTimeEmployee(140000, "maryam", "ramzan", "maryam@hotmail.com");
            //foreach(Employee k in emp)
            //{
            //    k.PrintFullNAme();
            //}

            //Base b = new Derived();
            //b.Print();
            //int sum = 0;
            //add(12, 33, out sum);

            Student std = new Student();
            std.ID = 12;
            std.Name = "afshan";
            std.setcity("islamabad");
            std.Email = "afshan@hotmail.com";

            Console.WriteLine("id is {0}", std.ID);
            Console.WriteLine("name is {0}", std.Name);
            Console.WriteLine("email is {0}", std.Email);
            Console.WriteLine("city is {0}", std.getcity());


        }


        public class Student
        {
            private
                string name;
            string city;
            string email;
            int id;

            public int ID
            {
                set;
                get;
            }

            public string Name
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("name can't be null or empty");
                    }
                    else
                    {
                        this.name = value;
                    }
                }

                get
                {
                    return string.IsNullOrEmpty(this.name) ? "no name value" : this.name;
                }
            }

            public string Email { get => email; set => email = value; }

            public string getcity()
            {
                return string.IsNullOrEmpty(this.city) ? "no city value" : this.city;
            }

            public void setcity(string c)
            {
                if ((string.IsNullOrEmpty(c)))
                {
                    throw new Exception("city can not be null");
                }
                else
                {
                    this.city = c;
                }
            }

        }
        public static void add(int fn, int sn, int tn)
        {
            Console.WriteLine("Sum = {0}", fn + sn + tn);
        }
        public static void add(int fn, int sn, out int sum)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
            sum = fn + sn;
        }
        //public static void add(float fn, float sn)
        //{
        //    Console.WriteLine("Sum = {0}", fn + sn);
        //}
        //public static void add(int fn, float sn)
        //{
        //    Console.WriteLine("Sum = {0}", fn + sn);
        //}
    }
    public class Base
    {
        public virtual void Print()
        {
            Console.WriteLine("I am base class method");
        }
    }

    public class Derived : Base
    {
        public override void Print()
        {
            Console.WriteLine("I am derived class method");
        }
    }
    public class Employee
    {
        String FirstName;
        String LastName;
        string Email;

        public Employee(string fn, string ln, string em)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Email = em;
            Console.WriteLine("Employee Constructor");

        }
        public virtual void PrintFullNAme()
        {
            Console.WriteLine("Employee full name is {0} {1}", this.FirstName, this.LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        float YearlySalary;
        public FullTimeEmployee(int sal, string fn, string ln, string em) : base(fn, ln, em)

        {
            this.YearlySalary = sal;
            Console.WriteLine("Full Time Employee Constructor");
        }

        public override void PrintFullNAme()
        {

            Console.WriteLine("Employee FullTime function");
        }
    }
    public class PartTimeEmployee : Employee
    {
        float HourlyRate;
        public PartTimeEmployee(int hr, string fn, string ln, string em) : base(fn, ln, em)
        {
            this.HourlyRate = hr;
            Console.WriteLine("Part Time Employee Constructor");
        }

        public override void PrintFullNAme()
        {

            Console.WriteLine("Employee PartTime function");
        }

    }
}
