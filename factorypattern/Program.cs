using System;

namespace factorypattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int wheelcount;
            bool input = false;
            do
            {
                Console.WriteLine($"enter the amount of tires of a vehicle you want to create");

                input = int.TryParse(Console.ReadLine(), out wheelcount);

            } while (!input);

            IVehicle vehicle = VehicleFactory.GetVehicle(wheelcount);

            vehicle.Drive();

        }  
    }
}
