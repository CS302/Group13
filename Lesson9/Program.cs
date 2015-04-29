using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static bool workDone = false;
        static void Main(string[] args)
        {
            #region MyRegion
            /*Action<int, int> action = Sum;
            Func<DateTime, string> func = ToString;
            Console.WriteLine(func(DateTime.Now));*/

            /*Process[] processes = Process.GetProcesses();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "notepad";
            info.Arguments = @"C:\Lesson6\Point.txt";
            info.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(info);*/


            /*Process.Start("notepad++", @"C:\Lesson6\Point.txt");
            Process.Start("chrome", @"http:\\google.com");*/
            /*foreach (Process proc in processes)
            {
                if (proc.ProcessName == "notepad++")
                {
                    Console.WriteLine("Закрыт");
                    proc.Kill();
                }
            }*/
            /*foreach (Process proc in processes)
            {
                Console.WriteLine(proc.ProcessName);
                Console.WriteLine(proc.PeakPagedMemorySize64);
                try 
                { 
                    Console.WriteLine(proc.StartTime); 
                }
                catch { }
                Console.WriteLine();
            }*/
            
            #endregion

            Func<int, int, int> workItem = GetNumbers;
            
            IAsyncResult ires = workItem.BeginInvoke(10, 20, ShowGetNumbersResult, null);
            
            while (Console.ReadLine() != "exit")
            { }
        }

        static int GetNumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
                sum += i;
            }
            return sum;
        }
        static void ShowGetNumbersResult(IAsyncResult ires)
        {
            AsyncResult res = (AsyncResult)ires;
            Func<int, int, int> workItem = (Func<int, int, int>)res.AsyncDelegate;
            int sum = workItem.EndInvoke(ires);
            Console.WriteLine("сумма = {0}", sum);
            return;
        }

        static string ToString(DateTime time)
        {
            return time.ToLongDateString();
        }

        static void Sum(int a, int b)
        {
            double sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void Mul(int a, int b)
        {
            double mul = 1;
            for (int i = a; i <= b; i++)
            {
                mul *= i;
            }
            Console.WriteLine(mul);
        }
    }
}
