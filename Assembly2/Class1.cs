using System;
using Assembly1;
namespace Assembly2
{
    public class Assembly2Class1 : Assembly1Class3
    {
        public void Print()
        {
            Assembly1Class1 a1 = new Assembly1Class1();
            //a1.ID = 98;
            Assembly1Class3 a3 = new Assembly1Class3();
            base.ID=888;
            Assembly2Class1 a2 = new Assembly2Class1();
            a2.ID = 567;
        }
    }
    //types can only have internal or public access modifiers.
    // by default it is internal.
    //type members by default private.
    public class Assembly2Class2
    {
    }
}
