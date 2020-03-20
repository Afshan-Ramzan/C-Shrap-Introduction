using System;

namespace _20_ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter numerator :");
                int num;
                bool isnumsuccessful = Int32.TryParse(Console.ReadLine(), out num);
                if (isnumsuccessful)
                {
                    Console.WriteLine("enter denumerator :");
                    int denum;
                    bool isdenumsuccessful = Int32.TryParse(Console.ReadLine(), out denum);

                    if (isdenumsuccessful && denum != 0)
                    {
                        int result = num / denum;
                        Console.WriteLine("Result = {0}", result);
                    }
                    else
                    {
                        if (!isdenumsuccessful)
                        {
                            Console.WriteLine("enter a number in range {0} to {1}", int.MinValue, int.MaxValue);
                        }
                        else
                        {
                            Console.WriteLine("denumerator can not be zero");

                        }
                    }

                }
                else
                {
                    Console.WriteLine("enter a number in range {0} to {1}", int.MinValue, int.MaxValue);
                }



            }
            /* catch (FormatException)
             {
                 Console.WriteLine("enter a number please");

             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("denumerator can not be zero");

             }
             catch (OverflowException)
             {
                 Console.WriteLine("enter a number in range {0} to {1}", int.MinValue, int.MaxValue);

             } */
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }
}