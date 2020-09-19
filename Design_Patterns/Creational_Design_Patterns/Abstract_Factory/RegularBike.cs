using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Design_Patterns.Abstract_Factory
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    class RegularBike : IBike
    {
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }
}
