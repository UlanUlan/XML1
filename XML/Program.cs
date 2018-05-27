using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("root");

            XmlElement TOVAR = doc.CreateElement("TOVAR");
            TOVAR.InnerText = "TOVAR1";

            XmlElement NAIM = doc.CreateElement("NAIM");
            NAIM.InnerText = "Бензин";

            XmlElement PRICE = doc.CreateElement("PRICE");
            PRICE.InnerText = "20";

            TOVAR.AppendChild(NAIM);
            TOVAR.AppendChild(PRICE);
            root.AppendChild(TOVAR);
            doc.AppendChild(root);
            doc.Save("1.xml");

        }
    }
}
