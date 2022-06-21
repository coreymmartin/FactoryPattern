using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("oh no here I go building a new car again!");
        }
    }
}
