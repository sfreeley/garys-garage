using System;

namespace Garage
{
    public interface IGasVehicle
    {
        //in an interface, do not use public keyword on methods and properties; they are intrinsically public
        double FuelCapacity { get; set; }

        int CurrentTankPercentage { get; set; }

        int RefuelTank();

    }

}