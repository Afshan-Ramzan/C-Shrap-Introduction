using System;
using ProjectA.TeamA;
using PATB = ProjectA.TeamB;
namespace _7_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectA.TeamA.ClassA.print();
            ProjectA.TeamB.ClassA.print();
            PATB.ClassA.print();
            ClassA.print();

        }
    }


}
