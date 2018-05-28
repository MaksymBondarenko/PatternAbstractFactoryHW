using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Products;

namespace ConsoleApp1.Factories
{
    class AudiFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new AudiFamilyCar();
        }

        public override SportCar CreateSportCar()
        {
            return new AudiSportCar();
        }
    }
}
