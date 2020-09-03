using System;

namespace Garage
{
    public class Cessna : IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public string CurrentTankPercentage { get; set; }

        public string RefuelTank()
        {
            return CurrentTankPercentage = "100%";
        }

    }
}