using System;
using System.Collections.Generic;
using System.Text;

namespace factorypattern
{
    public interface IVehicle
    {
        public void build();
        void Drive();
    }
}
