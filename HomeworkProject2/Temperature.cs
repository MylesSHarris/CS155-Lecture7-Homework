using System;
namespace Project2
{
    public class Temperature
    {
        private double temperature;
        private char scale;

        public Temperature()
        {
            Set(0, 'C');
        }

        public Temperature(double temperature)
        {
            Set(temperature, 'C');
        }

        public Temperature(char scale)
        {
            Set(0, scale);
        }

        public Temperature(double temperature, char scale)
        {
            Set(temperature, scale);
        }

        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        public void SetScale(char scale)
        {
            this.scale = scale;
        }

        public void Set(double temperature, char scale)
        {
            SetTemperature(temperature);
            SetScale(scale);
        }

        public double GetTemperatureF()
        {
            if (scale == 'F') return Math.Round(temperature, 1);
            return Math.Round((temperature * 9) / 5 + 32, 1);
        }

        public double GetTemperatureC()
        {
            if (scale == 'C') return Math.Round(temperature, 1);
            return Math.Round((temperature - 32) *5 / 9, 1);
        }

        public override string ToString()
        {
            return $"Temperature(temperature={temperature} scale={scale})";
        }

        public bool Equals(Temperature other)
        {
            return other.GetTemperatureC().Equals(GetTemperatureC());
        }
    }
}
