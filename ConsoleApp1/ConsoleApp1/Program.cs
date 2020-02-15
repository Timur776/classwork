using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                S+= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(S);
        }
    }
}
