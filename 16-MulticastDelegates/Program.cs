using System;


public delegate void sampleDelegate();
public delegate void sampleoutDelegate(out int Integer);
public delegate int SampleReturnDelegtae();
namespace _16_Multicast_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            sampleDelegate del1, del2, del3, del4;
            del1 = new sampleDelegate(sampleMethod1);
            del2 = new sampleDelegate(sampleMethod2);
            del3 = new sampleDelegate(sampleMethod3);

            //multicast delegate.. point more than one function.
            // we can add and also subtract the delegate.
            //! method to create multicast D
            del4 = del1 + del2 + del3;
            del4();

            // 2 method for multi D
            sampleDelegate del = new sampleDelegate(sampleMethod1);
            del += sampleMethod2;
            del += sampleMethod3;
            del();
            Console.WriteLine("\n\n");

            // int return value it always return last invoked method val;
            SampleReturnDelegtae srd = new SampleReturnDelegtae(sampleReturn1);
            srd += sampleReturn2;
            int value = srd();
            Console.WriteLine(value);

            sampleoutDelegate sod = new sampleoutDelegate(sampleoutMethod1);
            sod += sampleoutMethod2;
            int result = 0;
            sod(out result);
            Console.WriteLine("value of last invoke method using out parameter in the result varibale is {0}", result);





        }

        public static int sampleReturn1()
        {
            return 1;
        }

        public static int sampleReturn2()
        {
            return 2;

        }
        public static void sampleMethod1()
        {
            Console.WriteLine("sample method 1 invoked");
        }

        public static void sampleMethod2()
        {
            Console.WriteLine("sample method 2 invoked");
        }

        public static void sampleMethod3()
        {
            Console.WriteLine("sample method 3 invoked");
        }
        public static void sampleoutMethod1(out int number)
        {
            number = 1;
        }

        public static void sampleoutMethod2(out int number)
        {
            number = 2;
        }

    }

}
