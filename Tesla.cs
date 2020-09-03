using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKwh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public override void Drive(Vehicle aVehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Tesla silently passes!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla turned {direction} and no one heard it coming.");
        }

        public override void Stop(string location)
        {
            Console.WriteLine($"The {MainColor} Tesla stopped at the {location} and silently parked.");
        }

        public int ChargeBattery()
        {

            return CurrentChargePercentage = 100;

        }

    }
}