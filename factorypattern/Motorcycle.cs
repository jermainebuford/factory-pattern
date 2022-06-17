using System;
using System.Collections.Generic;
using System.Text;

namespace factorypattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }

        public void build()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            Console.WriteLine($"this motorcycle is in drive");
        }

        
        
           
        
    }
}
