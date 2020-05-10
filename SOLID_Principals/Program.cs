using SOLID_Principals.Dependency_Inversion_Principle_DIP;
using SOLID_Principals.Liskov_Substitution_Principle_LSP;
using System;

namespace SOLID_Principals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();


            // LSP  Test
            AbstractShape shape = new Circle();
            Console.WriteLine(shape.GetShape());
            shape = new Triangle();
            Console.WriteLine(shape.GetShape());


            // DI
            IAutomobile automobile = new Jeep();
            IAutomobile automobile1 = new SUV();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobile.Ignition();
            automobile.Stop();
            AutomobileController automobileController1 = new AutomobileController(automobile1);
            automobile1.Ignition();
            automobile1.Stop();

            Console.Read();
        }
    }
}
