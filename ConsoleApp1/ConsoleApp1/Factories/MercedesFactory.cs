using ConsoleApp1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factories
{
    public class MercedesFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }

        public override SportCar CreateSportCar()
        {
            return new MercedesFamilyCar();
        }
    }
}
