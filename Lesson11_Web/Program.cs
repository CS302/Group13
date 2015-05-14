using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson11_Web
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://www.liqpay.com/exchanges/exchanges.cgi");
            Stream streamLiqPay = request.GetResponse().GetResponseStream();
            MoneyRates rates = new MoneyRates();
            rates.eur = new Eur();
            rates.rur = new Rur();
            rates.uah = new Uah();
            rates.usd = new Usd();

            XmlSerializer serializer = new XmlSerializer((new MoneyRates()).GetType());
            rates = (MoneyRates)serializer.Deserialize(streamLiqPay);
            streamLiqPay.Close();
        }
    }

    [Serializable]
    [XmlRoot("rates")]
    public class MoneyRates
    {
        [XmlElement("EUR")]
        public Eur eur;
        [XmlElement("RUR")]
        public Rur rur;
        [XmlElement("UAH")]
        public Uah uah;
        [XmlElement("USD")]
        public Usd usd;
    }
    [Serializable]
    public class Eur
    {
        public double RUR;
        public double UAH;
        public double USD;
    }
    [Serializable]
    public class Rur
    {
        public double EUR;
        public double UAH;
        public double USD;
    }
    [Serializable]
    public class Uah
    {
        public double EUR;
        public double RUR;
        public double USD;
    }
    [Serializable]
    public class Usd
    {
        public double EUR;
        public double RUR;
        public double UAH;
    }
}
