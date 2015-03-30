using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 10;
            Console.WriteLine(number);
            number = 100;
            Console.WriteLine(number);

            int number2 = 15;
            Console.WriteLine(number2);

            number = 10 * 2467 - 496;
            Console.WriteLine(number);

            number = 10 - number;
            Console.WriteLine(number);
            Console.WriteLine("*******************");

            number = 56 / 10; //дробная часть отбрасывается
            Console.WriteLine(number);

            number = 56 % 10;
            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine();

            number = 56;
            double price = (double)number / 10;
            Console.WriteLine(price);

            string text = "1456";
            int number3 = int.Parse(text);
            number3 = number3 + 1;
            Console.WriteLine(number3);

            char symbol = 'A';
            Console.WriteLine(symbol);

            Console.WriteLine("a"+"b"+"c");
            Console.WriteLine((int)'a');
            Console.WriteLine('a'+'b'+'c');
            Console.WriteLine((int)'0');

            bool flag = true;
            Console.WriteLine(flag);
            flag = true && false;
            Console.WriteLine(!flag);
            Console.WriteLine("*************");


            int number4 = 10;
            number4++;
            Console.WriteLine(number4);

            number4 += 2;
            Console.WriteLine(number4);

            

            //аналогично с использованием структур
            DateTime date = new DateTime(2015, 3, 30, 20, 18, 0);
            Console.WriteLine(date);
            Console.WriteLine(date.DayOfWeek);

            DayOfWeek day = DayOfWeek.Monday;
            Console.WriteLine((int)day);

            Users user = Users.Guest;
            if (user == Users.Guest)
            {
                Console.WriteLine("Зарегистрируйтесь");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Желтенький");
            Console.ReadLine();
        }
        enum Users
        {
            Admin, AuthUser, Guest, Banned
        }
    }
}
