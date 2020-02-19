using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double S = 1;
            for (int i = 2; ; i++)
            {
                double k = 1.0 / i * Math.Pow(-1, i);
                if (Math.Abs(k) < 0.001)
                {
                    break;
                }
                else
                {
                    S += k;
                }
            }
            Console.WriteLine(S);
        }
    }
}
