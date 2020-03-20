using System;

namespace datatype_converison
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 123.45f;
            int i = Convert.ToInt32(f);
            Console.WriteLine(i);

            string strNumber = "100tg";
            //int Num = int.Parse(strNumber);
            int Result = 0;
            bool isConversion = int.TryParse(strNumber, out Result);
            if (isConversion)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }

        }
    }
}
