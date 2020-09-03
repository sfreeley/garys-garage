using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive(Vehicle aVehicle)
        {
            Console.WriteLine($"The {MainColor} vehicle drives past Rrrrrrummbbblllleee!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} vehicle turned {direction}.");
        }

        public virtual void Stop(string location)
        {
            Console.WriteLine($"The {MainColor} vehicle stopped at the {location} and parked.");
        }
    }
}