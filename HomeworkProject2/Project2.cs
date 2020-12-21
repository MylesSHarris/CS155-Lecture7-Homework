using System;
namespace Project2
{
    public class Project2
    {
        static void Main(string[] arguments)
        {
            Temperature temperature = new Temperature();
            Console.WriteLine(temperature);

            temperature.Set(70, 'F');
            Console.WriteLine(temperature);
            Console.WriteLine($"{temperature.GetTemperatureC()} {temperature.GetTemperatureF()}");

            Temperature other_temperature = new Temperature(70, 'C');
            Console.WriteLine(temperature.Equals(other_temperature));

            other_temperature.SetScale('F');
            Console.WriteLine(temperature.Equals(other_temperature));
        }
    }
}
