using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            if (n>0) 
            {
                if (b>0)
                {
                    if (m > 0)
                    {
                        Console.WriteLine("+");
                    }
                    else 
                    {
                        Console.WriteLine("-");
                    }
                }
                else
                {
                    if (m > 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                }
            }
            else
            {
                if (b > 0)
                {
                    if (m > 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                }
                else
                {
                    if (m > 0)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
            }
                
            
        }
    }
}
