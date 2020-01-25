using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь "+(Math.PI * (R * R)));
            Console.WriteLine("Периметор "+(Math.PI * R * 2));
        }
    }
}
