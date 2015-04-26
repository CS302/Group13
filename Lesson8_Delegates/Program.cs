using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Delegates
{
    class Program
    {
        
        //void (int a, int b)
        /// <summary>
        /// Делегат на пустой метод с двумя параметрами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        delegate void BinaryOp(int a, int b);
        static void Main(string[] args)
        {
            // + - * / ^
            while (comand != "exit")
            {
                Math.Pow(4, 2);
                /*
                 * все операнды типа double
                 * операции + - * / (^)
                 * арифметическая операция выполняется по нажатию Enter
                 *   1 + 2
                 *   
                 *   1
                 *   +
                 *   2
                 *   Предусмотреть все возможные ошибки:
                 *   DivideByZeroException
                 *   FormatException
                 *   OverflowException
                 */
                /*
                 1
                 * 
                 2
                 
                 * 
                 *  1 + 2
                 *  
                 * 
                 */

                int x = 50 / 0;         //ошибка компиляции
                double y = 50.0 / 0;    //определена константа "бесконечность"
            }


            
            List<string> list = new List<string>();
            ArrayList list2 = new ArrayList();
            list2.Add(2);
            list2.Add("qwerty");
            BinaryOp op = new BinaryOp(Sum);
            op += Mul;
            op += Mul;
            op += new BinaryOp(Mul);
            op -= Mul;
            op(10, 20);
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
