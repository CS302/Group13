using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson10_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowProgInfo();
            double x = Sum(1.0, 2.0);
        }

        [Conditional("DEBUG")]
        public void ShowProgInfo()
        {
            MessageBox.Show("Приложение калькулятор версия 1.0.1");
        }

        [Obsolete("Этот метод устарел. новый метод Sum(double, double)", false)]
        public int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Метод суммирования двух чисел
        /// </summary>
        /// <param name="a">Первый операнд</param>
        /// <param name="b">Второй операнд</param>
        /// <returns>сумму двух чисел</returns>
        public double Sum(double a, double b)
        {
            return a + b;
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
#if DEBUG
            Random rnd = new Random();
            richTextBox3.Text = (rnd.Next(0, 100000)).ToString();
            MessageBox.Show("Купите продукт");
//#error Дописать какие-нибудь проверки
            //TODO дописать проверки
#else
            int a = int.Parse(richTextBox1.Text);
            int b = int.Parse(richTextBox2.Text);
            richTextBox3.Text = (a + b).ToString();
#endif
        }
    }
}
