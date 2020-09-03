using System;

namespace Garage
{
    public class Zero : IElectricVehicle
    {
        public double BatteryKwh { get; set; }

        public string CurrentChargePercentage { get; set; }

        public string ChargeBattery()
        {

            return CurrentChargePercentage = "100%";

        }

    }
}