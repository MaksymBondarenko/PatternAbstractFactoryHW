using ConsoleApp1.Clients;
using ConsoleApp1.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver(new MercedesFactory());
            driver.SpeedFaster();
            Console.WriteLine("===================");
            driver = new Driver(new AudiFactory());
            driver.SpeedFaster();
           
        }
    }
}
