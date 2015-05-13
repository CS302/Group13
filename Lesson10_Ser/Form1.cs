using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lesson10_Ser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(5, 49);
            p1.remark = "Первая точка";
            XmlSerialisation(p1);
        }
        private static void XmlSerialisation(Point p)
        {
            FileStream stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer format = new XmlSerializer(p.GetType());
            format.Serialize(stream, p);
            stream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point p2 = XmlDeserialization();
            label1.Text = (p2.x + " " + p2.y).ToString();
        }
        private static Point XmlDeserialization()
        {
            FileStream stream = new FileStream("data.xml", FileMode.Open, FileAccess.Read);
            Point p = new Point();
            XmlSerializer format = new XmlSerializer(p.GetType());
            p = (Point)format.Deserialize(stream);
            stream.Close();
            return p;
        }
    }

    [Serializable]
    public class Point
    {
        public int x;
        public int y;
        public string remark = "";

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {

        }
    }
}
