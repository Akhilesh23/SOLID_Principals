using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Design_Patterns.Factory_Method
{
    /// <summary>
    /// The 'Product' interface
    /// </summary>
    public interface IFactory
    {
        void Drive(int miles);
    }
}
