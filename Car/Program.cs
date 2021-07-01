using System;
using CarClass;

namespace CarNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Subaru", "WRX", 15, 28);
            Console.WriteLine($" Joe has a {car1.Make} {car1.Model} with a {car1.GasTankSize} gas tank, that gets {car1.MilesPerGallon}MPG.");
        }
    }

}
