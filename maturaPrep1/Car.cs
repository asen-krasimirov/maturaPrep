using System;
using System.Collections.Generic;

namespace maturaPrep1
{
    internal class Car
    {
        public string Brand;
        public int Year;
        public int Mileage;
        public double Value;
        public double price;

        public Car(string aBrand, int aYear, int aMileage, double aValue)
        {
            Brand = aBrand;
            Year = aYear;
            Mileage = aMileage;
            Value = aValue;
            price = Price();
        }

        public virtual double Price()
        {
            int yearsDriven = 2022 - Year;
            double price = 0;

            if (yearsDriven <= 3) price = Value * 0.8;
            else if (4 <= yearsDriven && yearsDriven <= 6) price = Value * 0.6;
            else price = Value * 0.3;

            return price;
        }
    }
}
