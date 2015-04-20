using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersLibrary;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            /*Point p1 = new Point(9, 150);
            p1.label = "Первая точка";
            SaveBin(p1);*/

            /*Point p2 = LoadBin();
            p2.Print();*/

            /*Point p1 = new Point(9, 150);
            p1.label = "Первая точка";
            SaveTxt(p1);*/

            /*Point p2 = LoadTxt();
            p2.Print();*/

            /*Worker[] workers = new Worker[5];
            workers[0] = new Driver("John", 25, 74885, "Audi", 256);
            workers[1] = new Manager("Svetlana", 23, 7254, 10);
            workers[2] = new Driver("Andrew", 45, 24825, "BMW", 177);
            workers[3] = new Manager("Elena", 37, 6785, 15);
            workers[4] = new Driver("Ivan", 27, 58724, "Ваз", 232);

            List<Worker> list = new List<Worker>();
            list.AddRange(workers);
            list.Reverse();
            list.Insert(0, new Manager("Olga", 24, 84653, 12));
            foreach (Worker i in list)
            {
                i.Print();
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add(".exe", 0);
            dict.Add(".txt", 0);

            dict[".exe"] += 1;

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*ArrayList list = new ArrayList();

            list.AddRange(workers);
            Console.WriteLine(list.Count);
            list.RemoveAt(3);
            Console.WriteLine(list.Count);
            (list[3] as Worker).Print();

            list.Add("rabotnik");

            foreach (object i in list)
            {
                (i as Worker).Print();
            }*/

            /*Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(queue.Peek());
            Console.WriteLine();
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());*/
            
            #endregion

            /*

              ) }
            
             * {
             * (
             * 

            */
            Point<int, int> p1 = new Point<int, int>(9, 150);
            p1.Print();
            Point<string, int> p2 = new Point<string, int>("John", 48651);
            p2.Print();
        }

        /*private static Point LoadTxt()
        {
            string path = @"C:\Lesson6\Point.txt";
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(stream);
            int x = int.Parse(reader.ReadLine());
            int y = int.Parse(reader.ReadLine());
            string label = reader.ReadLine();

            reader.Close();
            Point p = new Point(x, y);
            p.label = label;

            return p;
        }

        private static void SaveTxt(Point p1)
        {
            string path = @"C:\Lesson6\Point.txt";
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(p1.x);
            writer.WriteLine(p1.y);
            writer.WriteLine(p1.label);

            writer.Close();
        }

        private static Point LoadBin()
        {
            string path = @"C:\Lesson6\Point.bin";
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] mass = new byte[sizeof(int)]; //sizeof(int) == 4

            stream.Read(mass, 0, mass.GetLength(0));
            int x = BitConverter.ToInt32(mass, 0);
            stream.Read(mass, 0, mass.GetLength(0));
            int y = BitConverter.ToInt32(mass, 0);

            stream.Read(mass, 0, mass.GetLength(0));
            int length = BitConverter.ToInt32(mass, 0);
            byte[] lMass = new byte[length];
            stream.Read(lMass, 0, lMass.GetLength(0));
            string label = Encoding.UTF8.GetString(lMass);

            stream.Close();

            Point p = new Point(x, y);
            p.label = label;
            return p;
        }

        private static void SaveBin(Point p)
        {
            string path = @"C:\Lesson6\Point.bin";
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            byte[] xMass = BitConverter.GetBytes(p.x);
            stream.Write(xMass, 0, 4); //xMass.GetLength(0); == 4
            byte[] yMass = BitConverter.GetBytes(p.y);
            stream.Write(yMass, 0, 4);
            byte[] lMass = Encoding.UTF8.GetBytes(p.label);
            byte[] length = BitConverter.GetBytes(lMass.GetLength(0));
            stream.Write(length, 0, length.GetLength(0));
            stream.Write(lMass, 0, lMass.GetLength(0));
            stream.Close();
        }*/


    }
    class Point<T, M> where T : struct
    {
        public T x;
        public M y;
        
        
        public string label;
        public Point(T x, M y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}\n{2}", x, y, label);
        }
    }
}
