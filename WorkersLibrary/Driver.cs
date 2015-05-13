using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public sealed class Driver : Worker, IPayTax
    {
        public string carType;
        public int hours;

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Машина: " + carType);
            Console.WriteLine("Кол-во часов: " + hours);
            Console.WriteLine();
            Console.WriteLine();
        }
        public override double GetBonus()
        {
            return hours * 100;
        }

        public double PayTax()
        {
            double bonus = GetBonus();
            return bonus * 0.13;
        }

        public Driver(string name, int age, Int64 snn, string carType, int hours)
            : base(name, age, snn)
        {
            this.carType = carType;
            this.hours = hours;
            salary = 35000;
        }
    }
}
