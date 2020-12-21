using System;
namespace Project1
{
    public class Project1
    {
        static void Main(string[] arguments)
        {
            Odometer odometer = new Odometer(10, 250);
            Console.WriteLine($"Initial reading: {odometer}");

            odometer.Add(3, 60);
            Console.WriteLine($"After using 3 gallons over 60 miles: {odometer.MilesPerGallon()}");

            odometer.ResetMeter();
            Console.WriteLine($"Reset: {odometer}");
        }
    }
}
