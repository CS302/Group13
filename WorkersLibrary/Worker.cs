using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    /// <summary>
    /// Абстрактный базовый класс "Работник"
    /// </summary>
    public abstract class Worker
    {
        #region Поля
        /// <summary>
        /// Имя работника
        /// </summary>
        private string name; 
        private int age;
        private Int64 snn;

        
        protected int salary;
        public static int count;
        
        #endregion

        #region Свойства
        /// <summary>
        /// Возраст работника
        /// </summary>
        /// <value>
        /// Значение в диапазоне [18 - 65]
        /// </value>
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

        public Int64 Snn
        {
            get { return snn; }
            set { snn = value; }
        }
        #endregion

        #region Методы
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
        #endregion

        #region Конструкторы
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
        #endregion
    }
}
