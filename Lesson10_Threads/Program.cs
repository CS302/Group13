using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson10_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ThreadStart start = Test;
            Thread thread1 = new Thread(start);
            thread1.IsBackground = false;
            thread1.Priority = ThreadPriority.Highest;
            thread1.Name = "Первый поток";
            thread1.Start();


            Thread thread2 = new Thread(start);
            thread2.IsBackground = false;
            thread2.Priority = ThreadPriority.Lowest;
            thread2.Name = "Второй поток";
            thread2.Start();*/

            ParameterizedThreadStart start = Test;
            Thread thread1 = new Thread(start);
            thread1.Start(new string[] { "10", "20" });

            //интерфейс пользователя
            while (Console.ReadLine() != "exit"){}
        }
        static void Test(object data)
        {
            int[] array = (int[])data;
            int a = array[0];
            int b = array[1];
            for (int i = a; i < b; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
}
