using System;
using System.Collections.Generic;
using System.Text;

namespace factorypattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelcount)
        {
            switch (wheelcount)
            {
                case 2:
                    return new Motorcycle();
                    case 4:
                    return new Cars();
                default: 
                    return new Cars();
            }
        }
    }
}
