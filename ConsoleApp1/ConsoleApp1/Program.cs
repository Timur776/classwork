using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =
            int.Parse(Console.ReadLine());
            int m =
            int.Parse(Console.ReadLine());
            Console.WriteLine(Enumerable.Range(n+1, m-n-1).Select(x => x%5).Where(x => x==0).Count());

        }
    }
}
