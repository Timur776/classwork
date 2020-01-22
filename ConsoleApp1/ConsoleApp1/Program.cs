using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            
            if (primes.Contains(n))
            {
                Console.WriteLine("Boruto");
            }
            else
            {
                Console.WriteLine("Saske");
            } 
        }
    }
}
