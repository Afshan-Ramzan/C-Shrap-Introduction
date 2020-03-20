using System;

namespace _6_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("enter your range :");
            // int range = int.Parse(Console.ReadLine());
            //evennumber(range);
            Program p = new Program();
            //int s=p.ADD(range);
            //Console.WriteLine("sum of range is {0}", s);
            int i = 0;
            SimpleMethod(ref i);
            Console.WriteLine("value of i is " + i + "");

            //output parameters

            int sum = 0, product = 0;
            //Calculate(10, 10, out sum, out product);
            //Console.WriteLine("sum is {0} and product is {1} ", sum, product);

            int[] num = new int[3];
            num[1] = 111;
            num[0] = 000;
            num[2] = 222;
            ParamsMethod(num);
            ParamsMethod();
        }

        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("there are {0} elements", numbers.Length);
            foreach (int k in numbers)
            {
                Console.WriteLine(k);
            }
        }

        public static void Calculate(int FN, int SN, out int sum, out int product)
        {
            sum = FN + SN;
            product = FN * SN;
        }
        public static void SimpleMethod(ref int j)
        {
            j = 1001;
        }
        public int ADD(int range)
        {
            int i = 0;
            int sum = 0;
            while (i <= range)
            {
                sum += i;
                i++;

            }
            return sum;
        }
        public static void evennumber(int r)
        {
            int start = 0;
            while (start <= r)
            {
                Console.WriteLine(start);
                start++;
            }
        }
    }
}
