using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.Interface_Segregation_Principle_ISP
{
    class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            throw new NotImplementedException();
        }

        public void CCProcess()
        {
            throw new NotImplementedException();
        }
    }
}
