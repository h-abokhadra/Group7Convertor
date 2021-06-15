using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Authors: Riyadh, Vlada, May 2021

namespace Group7Convertor
{
    class ConvertorTest
    {
       public static double Addition(double x, double y)
        {
            x += y;
            return x;
        }
        public static double Substraction(double x, double y)
        {
            x -= y;
            return x;
        }
        public static double Multiplication(double x, double y)
        {
            x *= y;
            return x;
        }
        public static double Division(double x, double y)
        {
            x /= y;
            return x;
        }
        public static double Modulus(double x, double y)
        {
            x = x % y;
            return x;
        }

        public static double Power(double x, double y)
        {
            x = Math.Pow(x, y);
            return x;
        }
        public static double Exponential(double x)
        {
            x = Math.Exp(x);
            return x;
        }
        public static double DividedByX(double x)
        {
            x = 1 / x;
            return x;
        }
        public static double Log(double x)
        {
            x = Math.Log(x, 10);
            return x;
        }
        public static double Ln(double x)
        {
            x = Math.Log(x);
            return x;
        }
        public static double SquareRoot(double x)
        {
            x = Math.Sqrt(x);
            return x;
        }
        public static double Factorial(double x)
        {
            double fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static double Absolute(double x)
        {
            x = Math.Abs(x);
            return x;
        }


    }
}
