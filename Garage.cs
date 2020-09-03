using System;
using System.Collections.Generic;

namespace Garage
{
    public class Garage
    {

        public List<IElectricVehicle> ElectricVehicles { get; set; }
        public List<IGasVehicle> GasVehicles { get; set; }

    }
}