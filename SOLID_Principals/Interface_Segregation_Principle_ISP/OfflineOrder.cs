using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.Interface_Segregation_Principle_ISP
{
    class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            throw new NotImplementedException();
        }
    }
}
