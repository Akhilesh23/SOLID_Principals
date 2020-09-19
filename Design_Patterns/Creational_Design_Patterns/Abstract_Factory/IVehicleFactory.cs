using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Design_Patterns.Abstract_Factory
{
    /// <summary>
    /// The 'AbstractFactory' interface. 
    /// </summary>
    interface IVehicleFactory
    {
        IBike GetBike(string Bike);
        IScooter GetScooter(string Scooter);
    }
}
