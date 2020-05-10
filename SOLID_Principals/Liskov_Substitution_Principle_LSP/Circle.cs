using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.Liskov_Substitution_Principle_LSP
{
    class Circle : Triangle
    {
        public override string GetShape() 
        { 
            return "Circle"; 
        }
    }
}
