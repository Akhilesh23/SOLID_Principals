using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.OCP
{
    interface IAccount
    {
        // members and function declaration, properties 
        decimal Balance { get; set;}
        decimal CalcInterest();
    }
}
