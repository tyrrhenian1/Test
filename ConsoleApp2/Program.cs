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
        public static double Cos(double x)
        {
            const int iterations = 30;
            var res = 0d;
            var pow = 1d;
            var sign = 1;

            for (int i = 0; i < iterations; i++)
            {
                if (i % 2 == 0)
                {
                    res += pow * sign;
                    sign *= -1;
                }
                pow *= x / (i + 1);
            }

            return Math.Round(res,4);
        }
    }
}
