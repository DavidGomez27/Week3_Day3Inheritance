﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle baseVehicle = new Vehicle(4, 2000, "Red", 55.0d);

            baseVehicle.Move();
            baseVehicle.Move();
            Console.WriteLine(baseVehicle.DistanceTraveled);

           






        }
    }
}
