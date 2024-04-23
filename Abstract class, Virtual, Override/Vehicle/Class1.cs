using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override.Vehicle
{
    static void Main(string[] args)
    {
        Car car = new(4, true, "BMW", "lexus", "black", 3, 210);
        car.GetInfo();

        car.AverageSpeed();
        car.ToString();

        Bicycle bicycle = new Bicycle("dag", "stels", "audi", "black",40, 250);
        Bicycle bicycle1 = new Bicycle("yaris", "stels", "almbargambag", "red", 9, 150);
        Bicycle bicycle2 = new Bicycle("seheer", "nimh", "bungo", "red", 50, 375);
        Bicycle[] bicycles = { bicycle, bicycle1, bicycle2 };
        foreach (var item in bicycles)
        {
            item.GetInfo();
            item.AverageSpeed();
            item.ToString();
        }

    }
}
