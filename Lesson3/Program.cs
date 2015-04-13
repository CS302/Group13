using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] names = new string[] { "John", "Svetlana", "Freddy", "Kate", "Phillip", "Ivan" };
            Worker[] workers = new Worker[rnd.Next(5, 10)];
            for (int i = 0; i < workers.GetLength(0); i++)
            {
                if (rnd.Next(0, 2) == 0)
                {
                    workers[i] = new Driver(names[rnd.Next(0, names.GetLength(0))], 
                        rnd.Next(18, 66), 
                        rnd.Next(111111, 999999),
                        "Lada", 
                        rnd.Next(10, 256));
                }
                else
	            {
                    workers[i] = new Manager(names[rnd.Next(0, names.GetLength(0))],
                        rnd.Next(18, 66), 
                        rnd.Next(111111, 999999),
                        rnd.Next(10, 25));
	            }
            }

            for (int i = 0; i < workers.GetLength(0); i++)
            {
                workers[i].Print();
            }

            /*Driver driver = new Driver("Ivan", 29, 87652, "Volvo", 256);
            Console.WriteLine(driver.PayTax());
            Manager manager = new Manager("Svetlana", 25, 48653, 10);
            Worker worker = manager;*/
                        
            /*if (worker is Driver)
            {
                Driver dr = (Driver)worker;
                Console.WriteLine(dr.hours);
            }*/

            /*Driver dr = worker as Driver;
            if (dr != null)
            {
                Console.WriteLine(dr.hours);
            }


            Console.WriteLine(Worker.count);*/
            Console.WriteLine();
        }
        private static void Arrays()
        {
            int[] array = new int[10] { 10, 2, 3, 4, -55, 6, -7, 80, 9, 10 };

            int min = array[0];
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    k = i;
                }
            }
            Console.WriteLine("Минимальный элемент = " + min);
            Console.WriteLine("Его индекc = " + k);
            int x = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] == x)
                {
                    Console.WriteLine("Найден элемент с индексом " + i);
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Такого элемента в массиве не обнаружено.");
            }
        }
    }
    abstract class Worker
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
            :this(name, age, 0)
        {   }
    }

    sealed class Driver : Worker, IPayTax
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

    sealed class Manager : Worker, IPayTax 
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
