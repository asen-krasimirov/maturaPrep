using System;
using System.Collections;
using System.Collections.Generic;


namespace maturaPrep1
{
    internal class Program
    {
        public class myComparer : IComparer
        {
            int IComparer.Compare(Object xx, Object yy)
            {
                Car x = (Car)xx;
                Car y = (Car)yy;
                return y.price.CompareTo(x.price);
            }
        }

        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Game\Desktop\C# BASICS\demo_projects\maturaPrep1\maturaPrep1\data.txt");

            ArrayList vehicles = new ArrayList();

            for (int index = 0; index < lines.Length; index += 3)
            {
                bool isCar = lines[index] == "1";
                string brandName = lines[index+1];
                string[] values = lines[index+2].Split(' ');

                if (isCar)
                {
                    Car vehicle = new Car(brandName, int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]));
                    vehicles.Add(vehicle);
                }
                else
                {
                    Truck vehicle = new Truck(brandName, int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3]));
                    vehicles.Add(vehicle);
                }
            }

            vehicles.Sort(new myComparer());

            foreach (Car vehicle in vehicles) Console.WriteLine($"{vehicle.Brand}: {vehicle.Mileage} km, {vehicle.price:f2}");
            // Console.ReadLine();
        }
    }
}
