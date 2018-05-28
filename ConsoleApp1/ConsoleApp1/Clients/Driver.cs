using ConsoleApp1.Factories;
using ConsoleApp1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clients
{
    public class Driver
    {
    private SportCar sport;
    private FamilyCar family;
    

        public Driver(CarFactory factory)
    {
            sport = factory.CreateSportCar();
            family = factory.CreateFamilyCar();
           
    }

    public void SpeedFaster()
    {
            sport.Speed();
            family.Speed();          
    }
    }
}
