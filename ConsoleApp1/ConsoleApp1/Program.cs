using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long min = Int64.MaxValue;
            long max = Int64.MinValue;
            for (int i = 0; i < n; i++)
            {
                long v =long.Parse(Console.ReadLine());
                max = Math.Max(v, max);
                min = Math.Min(v, min);
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min {min}");
        } 
    }
}
