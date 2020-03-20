using System;
using System.Collections.Generic;


class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    //function as parameter
    public static void Promoted(List<Employee> emplist, checkPromotion Iselibigibletopromote)
    {
        foreach (Employee employee in emplist)
        {
            if (Iselibigibletopromote(employee))
            {
                Console.WriteLine(employee.Name + " Promoted ");
            }
        }
    }
}

public delegate void HEllofunctionDelegate(string message);
delegate bool checkPromotion(Employee emp);

namespace _15_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // A delegate is a type safe function pointer;
            //HEllofunctionDelegate del = new HEllofunctionDelegate(Hello);
            //del("Hello from delegate");

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "afshan", Salary = 100000, Experience = 5 });
            emplist.Add(new Employee() { ID = 102, Name = "noreen", Salary = 100000, Experience = 10 });

            emplist.Add(new Employee() { ID = 103, Name = "asma", Salary = 100000, Experience = 3 });

            emplist.Add(new Employee() { ID = 105, Name = "kanza", Salary = 100000, Experience = 4 });
            checkPromotion isprom = new checkPromotion(Promote);

            Employee.Promoted(emplist, isprom);
            Employee.Promoted(emplist, emp => emp.Experience >= 5);

        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}








