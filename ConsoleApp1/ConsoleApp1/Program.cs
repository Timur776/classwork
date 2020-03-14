using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                ulong a = 1;
                ulong b = 1;
                ulong S = 2;
                for (int i = 0; i < n - 2; i++)
                {

                    ulong c = a + b;
                    a = b;
                    b = c;
                    S = c + S;
                }
                Console.WriteLine(S);
            }

        }
    }
}