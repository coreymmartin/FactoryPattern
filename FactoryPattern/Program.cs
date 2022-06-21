using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    internal class Program
    {
        static int AskNumTires(string msg = "how many tires on the vehicle?")
        {
            bool gotInt = false;
            bool intGood = false;
            int userInput;
            do
            {
                Console.Clear();
                Console.WriteLine(msg);
                gotInt = int.TryParse(Console.ReadLine(), out userInput);
                intGood = (gotInt && userInput > 1);
            } while (!intGood);
            return userInput;
        }

        static void Main(string[] args)
        {
            IVehicle vehicle = VehicleFactory.GetVehicle(AskNumTires());
            vehicle.Drive();
        }
    }
}
