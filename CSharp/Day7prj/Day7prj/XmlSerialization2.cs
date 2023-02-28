using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Day7prj
{
   public class Book
    {
        [XmlElementAttribute]
        public string authorname;
        [XmlElementAttribute]
        public string bookname;
        [XmlElementAttribute]
        public int yearpublished;

        public Book(string aname,string bname, int yr)
        {
            authorname = aname;
            bookname = bname;
            yearpublished = yr;
        }
        public Book() { }
    }
    class XmlSerialization2
    {
        static void Main()
        {
            //  xml_Serialize();
            //  xml_Deserialize();
            string xmldata = serialize_xml();
            Console.WriteLine(xmldata);
            deserialize_xml(xmldata);
            Console.Read();
        }

        public static void xml_Serialize()
        {
            string path = "MyXmlFile.xml";
            XmlSerializer xml_ser = new XmlSerializer(typeof(Book));
            Book b1 = new Book("Amish Tripathi", "The Son of Vayu Putra", 2009);
            StreamWriter sw = new StreamWriter(path);
            xml_ser.Serialize(sw, b1);               
        }
        public static void xml_Deserialize()
        {
            string path1 = "MyXmlFile.xml";
            XmlSerializer xml_ser1 = new XmlSerializer(typeof(Book));
            // Book b2 = (Book)xml_ser1.Deserialize(new StringReader(xmlout));
            // Console.WriteLine($"{b2.authorname}, {b2.bookname}, {b2.yearpublished}");
            StreamReader reader = new StreamReader(path1);
            Book b2 = (Book)xml_ser1.Deserialize(reader);
          
            Console.WriteLine($"{b2.authorname}, {b2.bookname}, {b2.yearpublished}");
        }

       public static string serialize_xml()
        {
            XmlSerializer xser = new XmlSerializer(typeof(Book));
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            Book newbook = new Book("AA", "BB", 2008);
            xser.Serialize(sw, newbook);
            return sb.ToString();
        }

        public static void deserialize_xml(string f)
        {
            XmlSerializer xml_ser1 = new XmlSerializer(typeof(Book));
            Book b3 = (Book)xml_ser1.Deserialize(new StringReader(f));
            Console.WriteLine($"{b3.authorname}, {b3.bookname}, {b3.yearpublished}");
        }
    }
}
