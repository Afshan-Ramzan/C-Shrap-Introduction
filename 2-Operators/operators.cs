using System;

namespace Operators
{
    class operators
    {
        static void Main(string[] args)
        {
            int a = 12, b = 13;
            if (a == b)
            {
                Console.WriteLine("equal");

            }
            if(a==1 || b == 1)
            {
                Console.WriteLine("Hello");
            }
            bool isNumber10;
            int Number = 100;
            bool isNumber100 = ( Number) == 100 ? true : false;
            Console.WriteLine("Number == 10 is {0}", isNumber100);
            if (a == 12)
            {
                isNumber10 = true;
            }
            else
            {
                isNumber10 = false;
            }
            Console.WriteLine("Number == 12 is {0}", isNumber10);

            int? TicketonSale = null;
            int TicketAvailable = TicketonSale ?? 0;
            Console.WriteLine("Ticket Availble ==  {0}", TicketAvailable);
        }
    }
}
