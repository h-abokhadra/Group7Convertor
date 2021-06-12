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


            Console.WriteLine("Welcome, please choose an operation \n");

            //Displaying the operations list for the user

            Console.WriteLine("Press 1 for Addition \n");
            Console.WriteLine("Press 2 for Subtraction \n");
            Console.WriteLine("Press 3 for Multiplication \n");
            Console.WriteLine("Press 4 for Division \n");
            Console.WriteLine("Press 5 for Modulus \n");
            Console.WriteLine("Press 6 for Power \n");
            Console.WriteLine("Press 7 for Exponential \n");
            Console.WriteLine("Press 8 for DividedByX \n");
            Console.WriteLine("Press 9 for Log \n");
            Console.WriteLine("Press 10 for Ln \n");
            Console.WriteLine("Press 11 for SquareRoot \n");
            Console.WriteLine("Press 12 for Factorial \n");
            Console.WriteLine("Press 13 for Absolute \n");

            //Taking user inputs 
      
            Console.WriteLine("Enter the 1st number");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation number");
            int action = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            double num2 = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            //Switch statement for all the operations.
            switch (action)
            {
                case 1:
                    {
                        result = ConvertorTest.Addition(num1, num2);
                        break;
                    }
                case 2:
                    {
                        result = ConvertorTest.Substraction(num1, num2);
                        break;
                    }
                case 3:
                    {
                        result = ConvertorTest.Multiplication(num1, num2);
                        break;
                    }
                case 4:
                    {
                        result = ConvertorTest.Division(num1, num2);
                        break;
                    }
                case 5:
                    {
                        result = ConvertorTest.Modulus(num1, num2);
                        break;
                    }
                case 6:
                    {
                        result = ConvertorTest.Power(num1, num2);
                        break;
                    }
                case 7:
                    {
                        result = ConvertorTest.Exponential(num1);
                        break;
                    }
                case 8:
                    {
                        result = ConvertorTest.DividedByX(num1);
                        break;
                    }
                case 9:
                    {
                        result = ConvertorTest.Log(num1);
                        break;
                    }
                case 10:
                    {
                        result = ConvertorTest.Ln(num1);
                        break;
                    }
                case 11:
                    {
                        result = ConvertorTest.SquareRoot(num1);
                        break;
                    }
                case 12:
                    {
                        result = ConvertorTest.Factorial(num1);
                        break;
                    }
                case 13:
                    {
                        result = ConvertorTest.Absolute(num1);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong input, please try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }

    }
    }

