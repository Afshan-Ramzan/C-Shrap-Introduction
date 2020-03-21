using System;

namespace Assembly1
{
    public class Assembly1Class1
    {
         internal int ID = 101;

    }

    public class Assembly1Class2
    {
        public void SampleMethod()
        {
            Assembly1Class1 a1 = new Assembly1Class1();
            Console.WriteLine(a1.ID);
        }

    }

    public class Assembly1Class3
    {
        protected internal int ID=111;
    }
}
