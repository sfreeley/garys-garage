using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public override void Drive(Vehicle aVehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Cessna zips past!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna turned {direction} and rolled some more.");
        }

        public override void Stop(string location)
        {
            Console.WriteLine($"The {MainColor} Cessna stopped at the {location} and ran out of gas.");
        }

        public int RefuelTank()
        {
            return CurrentTankPercentage = 100;
        }

    }
}