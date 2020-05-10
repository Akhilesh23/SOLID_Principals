using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.Dependency_Inversion_Principle_DIP
{
    class SUV : IAutomobile
    {
        #region IAutomobile Members  
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }
        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
        #endregion
    }
}
