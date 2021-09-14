using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static double ArcSin(double x)
        {
            int steps = 30;
            double result = 0;
            for (int i = 0; i < steps; i++)
            {
                result += (Factorial(2 * i) * Math.Pow(x, 2 * i + 1)) / (Math.Pow(4, i) * Math.Pow(Factorial(i), 2) * (2 * i + 1));
            }
            return result;
        }
        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i; //или fact *= i;
            }
            return fact;
        }
    }
}
