using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This program is for creating a convertor application.
//Group7: Hoda - Riyadh - Vlada - Kimberly
namespace Group7Convertor
{
    class Convertor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please choose a command: \n");

            Console.WriteLine("Press 1 for Addition \n");
            Console.WriteLine("Press 2 for Subtraction \n");
            Console.WriteLine("Press 3 for Multiplication \n");
            Console.WriteLine("Press 4 for Division \n");
            Console.WriteLine("Press 5 for Modulus \n");
            Console.WriteLine("Press 6 for Factorial \n");
            Console.WriteLine("Press 7 for Absolute \n");
            Console.WriteLine("Press 8 for Power \n");
            Console.WriteLine("Press 9 for Exponential \n");
            Console.WriteLine("Press 10 for DividedByX \n");
            Console.WriteLine("Press 11 for Log \n");
            Console.WriteLine("Press 12 for Ln \n");
            Console.WriteLine("Press 13 for SquareRoot\n");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = ConvertorTest.Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }

    }
    }

