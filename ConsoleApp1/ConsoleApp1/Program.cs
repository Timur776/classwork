using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address, phone, fax, website, managerName, managerSurneme, managerPhone;
            name = Console.ReadLine();
            address = Console.ReadLine();
            phone = Console.ReadLine();
            fax = Console.ReadLine();
            website = Console.ReadLine();
            managerName = Console.ReadLine();
            managerSurneme = Console.ReadLine();
            managerPhone = Console.ReadLine();
            Console.WriteLine("имя компании "+(name));
            Console.WriteLine("адрес "+(address));
            Console.WriteLine("телефон "+(phone));
            Console.WriteLine("факс "+(fax));
            Console.WriteLine("сайт "+(website));
            Console.WriteLine("имя менеджера "+(managerName));
            Console.WriteLine("фамилия менеджера "+(managerSurneme));
            Console.WriteLine("телефон менеджера " + (managerPhone));
        }
    }
}
