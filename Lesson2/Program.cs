using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowArrays();

            //ShowRefAndValueTypes();

            //ShowJaggedArray();

            //ShowIfSwitch();

            
            /*int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < array.GetLength(0); i++)
                Console.WriteLine(array[i]);*/
            

            string str;
            /*do
            {
                Console.WriteLine("Приложение работает");
                str = Console.ReadLine();
                if (str == "exit")
                {
                    Console.WriteLine("Работа завершена");
                }
            } while (str != "exit");*/

            /*for (; ; )
            {
                Console.WriteLine("Приложение работает");
                str = Console.ReadLine();
                if (str == "exit")
                    break;
                else
                    Console.WriteLine("******");
                
            }*/

            int[,] table = new int[10, 10];
            
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        table[i,j] = 1;
                    }
                    else
	                {
                        table[i,j] = 0;
	                }
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void ShowIfSwitch()
        {
            string str = Console.ReadLine();
            if (str == "exit")
            {
                Console.WriteLine("работа приложения завершена.");
            }
            else
            {
                Console.WriteLine("Выполняется какая-то работа.");
            }

            switch (str)
            {
                case "exit":
                    Console.WriteLine("Работа приложения завершена.");
                    Thread.Sleep(2000); //подождать 2 секунды
                    Environment.Exit(0); //закрыть приложение
                    break;
                case "option1":
                    Console.WriteLine("Опция1 подключена.");
                    break;
                case "option2":
                case "option3":
                    Console.WriteLine("Что-то подключено");
                    break;
                default:
                    Console.WriteLine("Выполняется какая-то работа");
                    break;
            }
        }

        private static void ShowJaggedArray()
        {
            int[][] table = new int[3][];
            table[0] = new int[4];
            table[1] = new int[2];
            table[2] = new int[3];

            table[0][0] = 1;
            table[0][1] = 2;
            table[0][2] = 3;
            table[0][3] = 4;

            table[1][0] = 5;
            table[1][1] = 6;

            table[2][0] = 7;
            table[2][1] = 8;
            table[2][2] = 9;

            Console.WriteLine(table[0][0] + " " + table[0][1] + " " + table[0][2] + " " + table[0][3]);
            Console.WriteLine(table[1][0] + " " + table[1][1]);
            Console.WriteLine(table[2][0] + " " + table[2][1] + " " + table[2][2]);
        }

        private static void ShowRefAndValueTypes()
        {
            int[] a = new int[2] { 5, 5 };
            int[] b = new int[2] { 9, 9 };
            Console.WriteLine(a[0] + " " + a[1]);
            Console.WriteLine(b[0] + " " + b[1]);
            Console.WriteLine("-----------------");

            a = b;
            Console.WriteLine(a[0] + " " + a[1]);
            Console.WriteLine(b[0] + " " + b[1]);
            Console.WriteLine("-----------------");

            b[0] = 100;
            b[1] = 100;
            Console.WriteLine(a[0] + " " + a[1]);
            Console.WriteLine(b[0] + " " + b[1]);
            Console.WriteLine("-----------------");

            Console.WriteLine("=================");

            int x = 5;
            int y = 9;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("-----------------");

            x = y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("-----------------");

            y = 100;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("-----------------");
        }

        static void ShowArrays()
        {
            int[] numbers = new int[5] { 11, 22, 33, 44, 55 };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine("-----------------");
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.GetLength(0));

            Console.WriteLine("=================");

            int[,] table = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            table[0, 0] = 1;
            table[0, 1] = 2;
            table[0, 2] = 3;
            table[1, 0] = 4;
            table[1, 1] = 5;
            table[1, 2] = 6;

            Console.Write(table[0, 0] + " ");
            Console.Write(table[0, 1] + " ");
            Console.WriteLine(table[0, 2]);
            Console.Write(table[1, 0] + " ");
            Console.Write(table[1, 1] + " ");
            Console.WriteLine(table[1, 2]);
            Console.WriteLine("-----------------");
            Console.WriteLine(table.Length);
            Console.WriteLine(table.GetLength(0));
            Console.WriteLine(table.GetLength(1));
        }

        static int DoSmth(int a, int b)
        {
            return a + b;
        }
    }
}
