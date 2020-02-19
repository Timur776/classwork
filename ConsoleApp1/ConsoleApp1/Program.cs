using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 90;
            ulong  a = 1;
            ulong b = 1;
            for (int i = 0; i < n; i++) 
            {

                ulong  c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
          
        }
    }
}
