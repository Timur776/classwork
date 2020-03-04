using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if(a>d)
                    {
                        if (a > e)
                        {
                            Console.WriteLine(a);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        if (d > e)
                        {
                            Console.WriteLine(d);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
                else
                {
                    if(c>d)
                    {
                        if (c > e)
                        {
                            Console.WriteLine(c);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }                  
                    else
                    {
                        if (d > e)
                        {
                            Console.WriteLine(d);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }
                }

            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        if (b > e)
                        {
                            Console.WriteLine(b);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        if (d > e)
                        {
                            Console.WriteLine(d);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
                else
                {
                    if (c > d)
                    {
                        if (c > e)
                        {
                            Console.WriteLine(c);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        if (d > e)
                        {
                            Console.WriteLine(d);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
            }
        }
    }
}
