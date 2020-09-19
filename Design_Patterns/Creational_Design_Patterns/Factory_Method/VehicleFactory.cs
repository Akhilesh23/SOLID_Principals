using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Design_Patterns.Factory_Method
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);

    }
}
