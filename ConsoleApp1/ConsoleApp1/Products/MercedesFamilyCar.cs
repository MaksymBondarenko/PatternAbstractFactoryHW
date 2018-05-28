using ConsoleApp1.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
    public class MercedesFamilyCar : FamilyCar
    {
        public override void Speed()
        {
            Console.WriteLine("Speed=200 km");
        }
    }
}
