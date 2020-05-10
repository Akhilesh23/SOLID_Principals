using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principals.Liskov_Substitution_Principle_LSP
{
    class Triangle : AbstractShape
    {
        public override string GetShape() 
        { 
            return "Triangle";
        }
    }
}
