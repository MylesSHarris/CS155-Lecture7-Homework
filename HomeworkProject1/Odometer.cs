using System;
namespace Project1
{ 
    public class Odometer
    {

        private double fuelUsed;
        private int mileageDriven;

        public Odometer()
        {

        }

        public Odometer(double fuelUsed, int mileageDriven)
        {
            this.fuelUsed = fuelUsed;
            this.mileageDriven = mileageDriven;
        }

        public void ResetMeter()
        {
            fuelUsed = 0;
            mileageDriven = 0;
        }

        public void Add(double fuelUsed, int mileageDriven)
        {
            this.fuelUsed += fuelUsed;
            this.mileageDriven += mileageDriven;
        }

        public double MilesPerGallon()
        {
            return mileageDriven / fuelUsed;
        }

        public override string ToString()
        {
            return $"[fuelUsed={fuelUsed} mileageDriven={mileageDriven}]";
        }
    }
}
