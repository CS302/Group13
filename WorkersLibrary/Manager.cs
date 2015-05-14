using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public sealed class Manager : Worker, IPayTax
    {
        private int projectsCount;

        public int ProjectsCount
        {
            get { return projectsCount; }
            set { projectsCount = value; }
        }

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
}
