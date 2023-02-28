using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Day7prj
{
    //Data Annotation/Attribute  (Decorators/Metadata)
    [Serializable]
    class Products
    {
        public int Pid { get; set; }
        public string ProductName { get; set; }

        [NonSerialized]
        float ProductPrice;
        
        static void Main()
        {
            //object initialization
            Products product = new Products() { Pid = 1, ProductName = "Laptops", ProductPrice = 65000 };

            //let us do a binary serialization, using a binary formatter class or an interface
            //known as IFormatter
            IFormatter formatter = new BinaryFormatter(); //or

            BinaryFormatter bf = new BinaryFormatter();

            Stream stream = new FileStream(@"C:\Banu\Medusind\M_B2\datafile.txt", FileMode.Create, FileAccess.Write);


            //to actually serialize the product object
            formatter.Serialize(stream, product);
            stream.Close();

            //Now let us deserialize 

            stream = new FileStream("C:\\Banu\\Medusind\\M_B2\\datafile.txt", FileMode.Open, FileAccess.Read);
           Products returnproduct = (Products)formatter.Deserialize(stream);
            Console.WriteLine($"{returnproduct.Pid},{returnproduct.ProductName},{returnproduct.ProductPrice}");

            Console.WriteLine("-------Printing the Original Product Object-------");
            Console.WriteLine($"{product.Pid},{product.ProductPrice}");

            //Calling Xmlserialization technique
            Console.WriteLine("-------XML---------");
            Program.xml_Serialize();
            Console.Read();

        }
    }

    public class XmlSerializationEg
    {
        public string data1;
        public string data2;      
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //}
        //lets serialize using xml formatter
        public static void xml_Serialize()
        {
            XmlSerializationEg xmlobj = new XmlSerializationEg() { data1 = "Hello", data2 = "World" };
            XmlSerializer x = new XmlSerializer(xmlobj.GetType());
            x.Serialize(Console.Out, xmlobj);            
        }

              
    }

       
}

