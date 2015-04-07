using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays();

            Worker worker1 = new Worker("John", 25, 4465132);
            worker1.Print();

            Worker worker2 = new Worker("Natalie", 23, 78486548);
            worker2.Print();
            worker2.Age = 656; //не будет работать из-за свойства
            worker2.Print();
            Console.WriteLine(worker2.Age);

            Worker worker3 = new Worker("Alex", 27);
            worker3.Print();

            Worker worker4 = new Worker("Andre", 45, 87485132);
            worker4.Print();
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
    class Worker
    {
        private string name;
        private int age;
        public Int64 snn;

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
        

        public void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine();
        }

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


        public Worker(string name, int age, Int64 snn)
        {
            this.name = name;
            Age = age;
            this.snn = snn;
        }

        public Worker(string name, int age)
            :this(name, age, 0)
        {   }
    }
}
