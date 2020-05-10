using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.OCP
{
    //regular savings account
    class RegularSavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public decimal CalcInterest()
        {
            decimal interest = (Balance * 4) / 100;
            if (Balance < 1000)
                interest -= (Balance * 2) / 100;
            if (Balance < 50000)
                interest += (Balance * 4) / 100;

            return interest;
        }
    }
}
