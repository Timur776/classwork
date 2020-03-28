using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            foreach (char c in n)
            {
                if(c == '\t')
                {
                    Console.Write("\\t");
                }
                else
                {
                    Console.Write(c);
                }
            }
                       
        }
    }
}                              