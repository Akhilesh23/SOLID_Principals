using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Design_Patterns.Abstract_Factory
{
    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike- Name";
        }
    }
}
