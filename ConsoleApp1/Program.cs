using System;
using System.Collections.Generic;

namespace CarGarage
{
    public class Garage
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        public Garage(string name, string address)
        {
            Name = name;
            Address = address;
            Cars = new List<Car>();
        }

        public void ShowAll()
        {
            foreach (Car car in Cars)
            {
                car.Show();
            }
        }
    }

    public class Car : IComparable<Car>
    {
        public string Owner { get; set; }
        public string Number { get; set; }

        public Car(string owner, string number)
        {
            Owner = owner;
            Number = number;
        }

        public void Show()
        {
            Console.WriteLine($"Owner: {Owner}, Number: {Number}");
        }

        public int CompareTo(Car other)
        {
            return String.Compare(this.Owner, other.Owner, StringComparison.Ordinal);
        }
    }
}