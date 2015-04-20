using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public abstract class Worker
    {
        private string name;
        private int age;
        public Int64 snn;
        protected int salary;
        public static int count;

        public int Age
        {
            set
            {
                if ((value < 18) || (value > 65))
                {
                    Console.WriteLine("Неверно задан возраст!");
                }
                else
                {
                    age = value;
                }
            }
            get
            {
                return age;
            }
        }
        public string Name
        {
            get { return name; }
        }
        public virtual void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine("З/П: " + salary);
            Console.WriteLine("Премия: " + GetBonus());
        }
        public abstract double GetBonus();
        public void SetAge(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("Неверно укзан возраст!");
            }
            else
            {
                age = a;
            }
        }
        public int GetAge()
        {
            return age;
        }

        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.GetLength(0); i++)
            {
                workers[i].Print();
            }
        }

        public Worker()
        {

        }

        static Worker()
        {
            count = 0;
        }

        public Worker(string name, int age, Int64 snn)
        {
            this.name = name;
            Age = age;
            this.snn = snn;
            salary = 20000;
            count++;
        }

        public Worker(string name, int age)
            : this(name, age, 0)
        { }
    }

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

    public sealed class Manager : Worker, IPayTax
    {
        public int projectsCount;

        public Manager(string name, int age, Int64 snn, int projectsCount)
            : base(name, age, snn)
        {
            this.projectsCount = projectsCount;
            salary = 40000;
        }

        public override double GetBonus()
        {
            return projectsCount * 1500;
        }

        public double PayTax()
        {
            return 0.13 * GetBonus();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Проектов: " + projectsCount);
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public interface IPayTax
    {
        double PayTax();
    }
}
