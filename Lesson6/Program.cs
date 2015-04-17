using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Значимые типы
            /*int num1 = 100;
            int num2 = 200;

            num1 = num2; //по значению

            num2 = 300;
            Console.WriteLine(num1);
            Console.WriteLine(num2);*/
            /*Point p1 = new Point(100);
            Point p2 = new Point(200);
            p1 = p2; //по ссылке
            p2.x = 300;
            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);*/

            /*int x = 100;
            int y = 200;
            int z = Sum(x, y);
            Console.WriteLine(z);*/

            /*int a = 100;
            int b = 200;
            Switch(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);*/
            
            #endregion

            #region RefOut
            /*int[] mass = new int[5] { 1, 2, 3, 4, 5 };

            mass = DoubleMass(mass);

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[i]);
            }*/
            /*int number;
            bool flag = int.TryParse(Console.ReadLine(), out number);
            if (!flag)
            {
                Console.WriteLine("Число введено неверно!");
                Console.WriteLine(number);
            }
            else
            { 
                Console.WriteLine(number * number); 
            }*/
            
            #endregion

            /*string[] filePaths = Directory.GetFiles(@"C:\Lesson6", "*.exe", SearchOption.AllDirectories);
            for (int i = 0; i < filePaths.GetLength(0); i++)
            {
                Console.WriteLine(filePaths[i]);
                Console.WriteLine(File.GetCreationTime(filePaths[i]));
                Console.WriteLine();
            }*/

            /*DirectoryInfo dir = new DirectoryInfo(@"C:\Lesson6");
            FileInfo[] files = dir.GetFiles("*.exe", SearchOption.AllDirectories);
            for (int i = 0; i < files.GetLength(0); i++)
            {
                Console.WriteLine(files[i].FullName);
                Console.WriteLine(files[i].CreationTime);
                Console.WriteLine(files[i].Length);
                Console.WriteLine();
            }
            Console.WriteLine(dir.Parent.FullName);*/

            /*FileInfo file1 = new FileInfo(@"C:\Lesson6\1.txt");
            file1.Create();
            FileInfo file2 = new FileInfo(@"C:\Lesson6\extjs\2.txt");
            file2.Create();
            FileInfo file3 = new FileInfo(@"C:\Lesson6\Test\3.txt");
            if (file3.Directory.Exists)
            {
                file3.Create();
            }
            else
            {
                file3.Directory.Create();
                file3.Create();
            }

            Directory.CreateDirectory(@"C:\Lesson6\Test\1\2\3\4\5\6\7\8\9");*/
            string path = @"C:\Lesson6\Test\1\2\3\NewText.txt";
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetExtension(path));

            string dir = @"C:\Lesson6\Test\1\2\3";
            string temp = "newDir";
            string fileName = "newData.txt";
            string fullname = dir + "\\" + temp + "\\" + fileName;
            Console.WriteLine(fullname);
            fullname = Path.Combine(dir, temp, fileName);
            Console.WriteLine(fullname);

            Directory.CreateDirectory(@"Lesson6\Test\1\2\3");

            File.Move(@"директория\исходное имя", "итоговое имя файла");

        }
        static int[] DoubleMass(int[] mass)
        {
            int[] newMass = new int[mass.GetLength(0) * 2];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                newMass[i] = mass[i];
                newMass[i + mass.GetLength(0)] = mass[i];
            }
            return newMass;
        }
        /*static void DoubleMass(ref int[] mass)
        {
            int[] newMass = new int[mass.GetLength(0) * 2];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                newMass[i] = mass[i];
                newMass[i + mass.GetLength(0)] = mass[i];
            }
            mass = newMass;
        }*/
        static void Switch(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
    class Point
    {
        public int x;
        public Point(int x)
        {
            this.x = x;
        }
    }
}
