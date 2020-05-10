using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.OCP
{
    //Salary savings account 
    class SalarySavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0; 
        public decimal CalcInterest() 
        { 
            decimal Interest = (Balance * 5) / 100; 
            return Interest; 
        }
    }
}
