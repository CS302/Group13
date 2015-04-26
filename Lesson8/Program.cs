using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Work work = new Work();
                work.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Приложение не может выполнить свою задачу.\nОбратитесь к системному администратору.");
                SaveErrorInfo(ex);
            }
        }
        public static void SaveErrorInfo(Exception ex)
        {
            FileStream stream = new FileStream("error.log", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(DateTime.Now);
            writer.WriteLine(ex.Message);
            writer.WriteLine(ex.StackTrace);
            writer.WriteLine("---------------------------------");
            writer.Close();
        }
    }
    class Work
    {
        public void Start()
        {
            //throw new Exception("А мне захотелось");
            /*int number = GetNumber();
            Console.WriteLine(10000 / number);*/
            int a = 2000000000;
            int b = 2000000000;
            try
            {
                checked
                {
                    int c = a + b;
                    Console.WriteLine(c);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Перепполнение разрядной сетки.");
            }
            
        }

        private static int GetNumber()
        {
            while (true)
            {
                try
                {
                    int number;
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number * number);
                    return number;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Program.SaveErrorInfo(ex);
                    Console.WriteLine("Нельзя вводить буквы.");
                    Console.WriteLine("Попробуйте еще раз:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Program.SaveErrorInfo(ex);
                    Console.WriteLine("Диапазон возможных значений: [{0}, {1}]", int.MinValue, int.MaxValue);
                    Console.WriteLine("Попробуйте еще раз:");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Program.SaveErrorInfo(ex);
                    Console.WriteLine("Произошла неизвестная ошибка.");
                    Console.WriteLine("Попробуйте еще раз:");
                }
            }
        }
    }
}
