using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Design_Patterns.Abstract_Factory
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}
