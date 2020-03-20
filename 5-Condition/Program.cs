using System;

namespace _5_Condition_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number :");
            //int UserName = int.Parse(Console.ReadLine());

            #region if else
            //if (UserName == 1)
            //{
            //    Console.WriteLine("your number is one");
            //}
            //else if (UserName == 2)
            //{
            //    Console.WriteLine("your number is two");

            //}
            //else if (UserName == 3)
            //{
            //    Console.WriteLine("your number is three");
            //}
            //else
            //{
            //    Console.WriteLine("your number is not between 1-3");
            //}

            /*  if(UserName==10 || UserName == 20)
              {
                  Console.WriteLine("your number is 10 or 20");
              } */
            #endregion

            #region swtich
            /* switch(UserName){
                 case 1:
                 case 3:
                 case 5:
                 case 7:
                 case 9:
                     Console.WriteLine("your number is odd");
                     break;
                 case 2:
                 case 4:
                 case 6:
                 case 8:
                 case 10:
                     Console.WriteLine("your number is even");
                     break;
                 default:
                     Console.WriteLine("your number is out of range of 1-10");
                     break;
             }
             */
            // sample program 
            /*int TotalCoffeeCost = 0;
            Start:
            Console.WriteLine("enter your size \n1: small\n2:medium\n3:large");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid", choice);
                    goto Start;
                    
            }
            Dlocation:
            Console.WriteLine("do your want to buy another coffee? yes or no");
            string userdecision = Console.ReadLine();
            switch (userdecision)
            {
                case "yes":
                case "YES":
                case "Yes":
                    goto Start;
                case "NO":
                case "no":
                case "No":
                    break;

                default:
                    Console.WriteLine("your choice is invalid please enter again .");
                    goto Dlocation;
                    break;
            }
            Console.WriteLine("Thankyou for shopping\nyour bill is {0} $", TotalCoffeeCost); */
            #endregion

            #region while loop
            /* Console.WriteLine("Please enter your target?");
             int userTarget = int.Parse(Console.ReadLine());
             int start = 0;
             while (start <= userTarget)
             {
                 Console.WriteLine(start);
                 start += 2;
             }
             */
            #endregion

            #region do while loop

            //int start = 0;
            //string choice=string.Empty ;
            //do
            //{
            //    Console.WriteLine("Please enter your target?");
            //    int userTarget = int.Parse(Console.ReadLine());
            //    start = 0;

            //    do
            //    {

            //        Console.WriteLine(start);
            //        start += 2;
            //    } while (start <= userTarget);




            //    do
            //    {
            //        Console.WriteLine("Do you want to contiune: yes or no");
            //        choice = Console.ReadLine().ToLower();
            //        if (choice != "yes" && choice != "no")
            //        {
            //            Console.WriteLine("Invalid choice, Please enter yes or no");
            //        }

            //    } while (choice != "yes" && choice != "no");
            //} while (choice == "yes");
            #endregion

            #region for loop
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            //int i = 0;
            foreach (int k in Numbers)
            {
                Console.WriteLine(k);

            }
            #endregion
        }
    }
}
