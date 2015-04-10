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
            int x = 10;
            double y = Math.Pow(x, 2); //пример статичного метода от статичного класса
            
            Worker[] workers = new Worker[5];
            workers[0] = new Driver("John", 25, 4465132, "BMW", 278);
            workers[1] = new Manager("Natalie", 23, 78486548, 13);
            workers[2] = new Manager("Andre", 45, 87485132, 25);
            workers[3] = new Driver("Ivan", 29, 87652, "Volvo", 256);
            workers[4] = new Manager("Svetlana", 25, 48653, 10);

            for (int i = 0; i < workers.GetLength(0); i++)
            {
                workers[i].Print();
            }

            Driver driver = new Driver("Ivan", 29, 87652, "Volvo", 256);
            Manager manager = new Manager("Svetlana", 25, 48653, 10);
            Worker worker = manager;

            /*if (worker is Driver)
            {
                Driver dr = (Driver)worker;
                Console.WriteLine(dr.hours);
            }*/

            Driver dr = worker as Driver;
            if (dr != null)
            {
                Console.WriteLine(dr.hours);
            }


            Console.WriteLine(Worker.count);
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

    sealed class Driver : Worker
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

        public Driver(string name, int age, Int64 snn, string carType, int hours)
            : base(name, age, snn)
        {
            this.carType = carType;
            this.hours = hours;
            salary = 35000;
        }
    }

    sealed class Manager : Worker 
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

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Проектов: " + projectsCount);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
