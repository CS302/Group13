using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9_types
{
    class Program
    {
        static Queue<int> queue;
        static object block = new object();
        static void Main(string[] args)
        {
            #region MyRegion
            /*var number = 100.0;
            //Int32 number = 100;
            var text = "строка";
            Console.WriteLine(text.Length);
            var x = GetNumber();*/
            //number = "строка"; ошибка компиляции

            /*dynamic number = 10;
            Console.WriteLine(number);

            number = number + 100;
            Console.WriteLine(number);

            number = "строка";
            Console.WriteLine(number);

            number = number + " " + 10;
            Console.WriteLine(number);*/
            
            #endregion
            queue = new Queue<int>();
            for (int i = 1; i <= 100; i++)
            {
                queue.Enqueue(i);
            }
            Action<int> workItem = CalcQueItem;
            workItem.BeginInvoke(1, null, null);
            workItem.BeginInvoke(2, null, null);
            Console.ReadLine();

        }
        static void CalcQueItem(int id)
        {
            while (queue.Count != 0)
            {
                int number;
                Thread.Sleep(10);
                lock (block)
                {
                    number = queue.Dequeue();
                }
                number *= number;
                Thread.Sleep(100);
                Console.WriteLine("{0} - {1}", id, number);
            }
        }
        static double GetNumber()
        {
            return 100;
        }
    }
}
