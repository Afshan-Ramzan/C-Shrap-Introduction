using System;

namespace _21_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Gender g = (Gender)3;
            Console.WriteLine(g.ToString());
            short[] values=(short []) Enum.GetValues(typeof(Gender));
            foreach(short val in values)
            {
                Console.WriteLine(val);
            }

            string[] names = (string[])Enum.GetNames(typeof(Gender));
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Customer[] customers = new Customer[3];
            customers[0] = new Customer { Name = "mary", Gender = Gender.Female };
            customers[1] = new Customer { Name = "mark", Gender = Gender.Male };
            customers[2] = new Customer { Name = "mary", Gender = Gender.Unknow };

            foreach(Customer customer in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1} ", customer.Name,GetGender( customer.Gender));
            }
        }


        public static string GetGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknow:
                    return "unknow";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "invaild data";
            }

        }
    }
}
//enums are value type strong type constant
public enum  Gender:short
{
    Unknow=3,
    Male=4,
    Female=6
}
class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}
