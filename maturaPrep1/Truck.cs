using System;
using System.Collections.Generic;

namespace maturaPrep1
{
    internal class Truck : Car
    {
        public int Tonnage;

        public Truck(string aBrand, int aYear, int aMileage, double aValue, int aTonnage) : base(aBrand, aYear, aMileage, aValue)
        {
            Tonnage = aTonnage;
            price = Price();
        }
        public override double Price()
        {
            int yearsDriven = 2022 - Year;
            double price = 0;

            if (yearsDriven <= 5) price = Value;
            else if (Tonnage <= 5) price = Value * 0.3;
            else if (5 < Tonnage && Tonnage <= 10) price = Value * 0.6;
            else price = Value * 0.8;

            return price;
        }
    }
}
