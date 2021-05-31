using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7Convertor
{
    class ConvertorTest
    {
        static double Addition(double x, double y)
        {
            x += y;
            return x;
        }
        static double Substraction(double x, double y)
        {
            x -= y;
            return x;
        }
        static double Multiplication(double x, double y)
        {
            x *= y;
            return x;
        }
        static double Division(double x, double y)
        {
            x /= y;
            return x;
        }
        static double Modulus(double x, double y)
        {
            x = x % y;
            return x;
        }
        static int Factorial(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static double Absolute(double x)
        {
            x = Math.Abs(x);
            return x;
        }
        static double Power(double x, int y)
        {
            x = Math.Pow(x, y);
            return x;
        }
        static double Exponential(double x)
        {
            x = Math.Exp(x);
            return x;
        }
        static double DividedByX(double x)
        {
            x = 1 / x;
            return x;
        }
        static double Log(double x)
        {
            x = Math.Log(x, 10);
            return x;
        }
        static double Ln(double x)
        {
            x = Math.Log(x);
            return x;
        }
        static double SquareRoot(double x)
        {
            x = Math.Sqrt(x);
            return x;
        }


    }
}
