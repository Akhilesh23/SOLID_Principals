using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.Dependency_Inversion_Principle_DIP
{
    class AutomobileController
    {
        IAutomobile m_Automobile; 
        public AutomobileController(IAutomobile automobile) 
        { 
            this.m_Automobile = automobile;
        }
        public void Ignition() 
        { 
            m_Automobile.Ignition(); 
        }
        public void Stop() 
        { 
            m_Automobile.Stop(); 
        }
    }
}
