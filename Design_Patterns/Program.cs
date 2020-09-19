using Design_Patterns.Creational_Design_Patterns.Abstract_Factory;
using Design_Patterns.Creational_Design_Patterns.Factory_Method;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /// <summary>
            /// 1. Factory Pattern Demo
            /// </summary>
            #region Factory Pattern Demo
            Console.WriteLine("Factory Pattern Demo!");
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.WriteLine("Factory Pattern Demo Completed!");
            Console.ReadKey();  
            
            #endregion

            /// <summary>
            /// 2. Abstract Factory Pattern Demo
            /// </summary>
            #region Abstract Factory Pattern Demo

            Console.WriteLine("Abstract Factory Pattern Demo!");
            IVehicleFactory honda = new HondaFactory();
            VehicleClient hondaclient = new VehicleClient(honda, "Regular");

            Console.WriteLine("******* Honda **********");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            hondaclient = new VehicleClient(honda, "Sports");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            IVehicleFactory hero = new HeroFactory();
            VehicleClient heroclient = new VehicleClient(hero, "Regular");

            Console.WriteLine("******* Hero **********");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

            heroclient = new VehicleClient(hero, "Sports");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

            Console.WriteLine("Abstract Factory Pattern Demo Completed!");
            Console.ReadKey();

            #endregion

        }
    }
}
