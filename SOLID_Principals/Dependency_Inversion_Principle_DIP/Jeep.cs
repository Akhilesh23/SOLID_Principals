using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.Dependency_Inversion_Principle_DIP
{
    class Jeep : IAutomobile
    {
        #region IAutomobile Members  
        public void Ignition()  
        {  
            Console.WriteLine("Jeep start"); 
        }    
        public void Stop()  
        { 
            Console.WriteLine("Jeep stopped."); 
        }  
        #endregion 
    }
}
