using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numTires)
        {
            switch (numTires)
            {
                case 2:
                case 3:
                    return new Motorbike();
                case 4:
                default:
                    return new Car();
            }
        }
    }
}
