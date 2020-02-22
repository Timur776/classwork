using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
                if (n > m)
                {
                n += m;
                m = n - m;
                n -= m;
                }
            Console.WriteLine(n);
            Console.WriteLine(m);
        }
    }
}
