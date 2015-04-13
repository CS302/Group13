using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Строки
            /*string text1 = "простая строка";
            string text2 = text1;

            text1 = "123";
            
            Console.WriteLine(text1);
            Console.WriteLine(text2);*/
            //string text = "первая\\123";
            //Console.WriteLine(text);
            /*string[] symbols = { "\\", "|", "/", "-" };
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(symbols[i%4] + "\r");
                //Thread.Sleep(200);
            }
            Console.WriteLine();
            string path = "C:\\Lesson6\\1.txt";
            //string path2 = Console.ReadLine();
            Console.WriteLine("наши занятия 'легкие'");
            
            char symbol = '\'';
            Console.WriteLine(symbol);

            string path2 = @"C:\Lesson6\extjs\examples\grouptabs\images\tickets.png";
            path = @"первая строка
вторая строка
                    примечание";
            Console.WriteLine(path);*/

            /*string text = "простая строка";
            Console.WriteLine(text.Length);
            Console.WriteLine(text[text.Length-1]);
            Console.WriteLine(text.CompareTo("простая не строка"));*/
            /*
             * 0 - строки идентичны
             * -1 - раньше по алфавиту
             * 1 - позже по алфавиту
             */
            /*Console.WriteLine(text.Contains("стр"));
            Console.WriteLine(text.Insert(0, "Это "));
            text = text.Insert(0, "Это ");
            Console.WriteLine(text.Remove(8, 3));
            Console.WriteLine(text.Replace('о', 'а'));
            Console.WriteLine(text.Replace("простая", "сложная"));
            Console.WriteLine();

            string data = "451;486153;486513;9846153";
            string[] items = data.Split(';');
            int sum = 0;
            for (int i = 0; i < items.GetLength(0); i++)
            {
                sum += int.Parse(items[i]);
            }
            Console.WriteLine(sum);

            string username = "MyName ";
            username = username.TrimEnd(' ');
            Console.WriteLine(username.ToUpper());
            Console.WriteLine(username.ToLower());*/

            /*int n = 1000000;
            StringBuilder data = new StringBuilder();
            Console.WriteLine(data.Capacity);
            for (int i = 0; i < n; i++)
            {
                data.Append(i);
            }
            //Console.WriteLine(data);
            Console.WriteLine(data.Length);
            Console.WriteLine(data.Capacity);
            Console.WriteLine(data.MaxCapacity);*/
            
            /*int x = 10;
            int y = 20;
            Console.WriteLine("X = {0}\nY = {1}\nИ еще раз координата X = {0}", x, y);

            double price = 99.9999;
            Console.WriteLine("Цена = {0}", price);
            Console.WriteLine();
            Console.WriteLine("Цена = {0:e}", price); //science
            Console.WriteLine();
            Console.WriteLine("Цена = {0:c}", price); //commercial

            price = 1.0/3;
            Console.WriteLine(price);
            Console.WriteLine();
            Console.WriteLine("Цена = {0:.0000}", price);
            Console.WriteLine();
            Console.WriteLine("Цена = {0:.####}", price);*/
#endregion

            Point p1 = new Point(213.846513, 45.8465);
            p1.Print();

            /*
             * science
             * [2.13846513e+002 ; 4.58465e+001]
             * 
             * human
             * (213.84 ; 45.84)
             */
            Console.WriteLine("{0:e}", p1);
            //[2.13846513e+002 ; 4.58465e+001]
            Console.WriteLine("{0:h}", p1);
            //(213.84 ; 45.84)
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            DateTime date = DateTime.Now;
            Console.WriteLine("{0:hh:mm}", date);
            Console.WriteLine("{0:yy.MM.dd hh:mm}", date);
            Console.WriteLine("{0:yyyy MMMM dddd hh:mm:ss}", date);
            // иМя ФаМиЛиЯ --> Имя Фамилия
        }
    }
    class Point : IFormattable
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}", x, y);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "e":
                    return String.Format("[{0:e} ; {1:e}]", x, y);
                case "h":
                    return String.Format("<{0:.##} ; {1:.##}>", x, y);
                default:
                    return ToString();
            }
        }
    }
}
