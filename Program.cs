using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanstiating new classes
            Zero fxs = new Zero();
            fxs.BatteryKwh = 300.00;
            fxs.CurrentChargePercentage = 20;
            Zero fx = new Zero();
            fx.BatteryKwh = 100.00;
            fx.CurrentChargePercentage = 50;
            Tesla modelS = new Tesla();
            modelS.BatteryKwh = 60;
            modelS.CurrentChargePercentage = 30;

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fx,
                fxs,
                modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            //iterating through the list of electric vehicles
            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            ram.FuelCapacity = 60.20;
            ram.CurrentTankPercentage = 70;
            Cessna cessna150 = new Cessna();
            cessna150.FuelCapacity = 90.21;
            cessna150.CurrentTankPercentage = 20;

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram,
                cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}