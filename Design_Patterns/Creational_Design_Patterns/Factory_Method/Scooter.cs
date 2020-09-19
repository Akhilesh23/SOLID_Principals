using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Design_Patterns.Factory_Method
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }
}
