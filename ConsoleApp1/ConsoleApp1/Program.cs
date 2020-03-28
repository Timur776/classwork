using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int m = 0;
            foreach (char c in n)
            {
                if ((c ==' ')||(c =='\t'))
                {
                    m++;
                } 
            }
            Console.WriteLine(m);
                       
        }
    }
}