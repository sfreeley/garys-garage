using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        //in an interface, do not use public keyword on methods and properties; they are intrinsically public
        double BatteryKwh { get; set; }

        string CurrentChargePercentage { get; set; }

        string ChargeBattery();

    }

}