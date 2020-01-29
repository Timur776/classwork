using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n % 10;
            int b = (n / 10) % 10;
            int c = (n / 100) % 10;
            int d = (n / 1000) % 10;
            if (n < 10000 && n > 999)
            {
                Console.WriteLine(a + b + c + d);
                Console.WriteLine($"{d}{c}{b}{a}");
                Console.WriteLine($"{d}{a}{c}{b}");
                Console.WriteLine($"{a}{c}{b}{d}");
            }
            else 
            {
                Console.WriteLine("потрачено");
            } 

        }
    }
}
