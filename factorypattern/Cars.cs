using System;
using System.Collections.Generic;
using System.Text;

namespace factorypattern
{
    public class Cars : IVehicle
    {
        public Cars()
        {

        }

        public void build()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            Console.WriteLine($"this car is in drive");
        }

        
        
            
        
    }
}
