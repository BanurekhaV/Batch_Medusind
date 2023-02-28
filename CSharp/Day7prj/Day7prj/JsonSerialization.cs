using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Day7prj
{
    [Serializable]
    class customer
    {
        public int Id = 0;
        public string Name = " ";
        public string City = " ";

        //let us JSON serialize the object and return it

        public string ToJson()
        {
            //make a stream object
            using(MemoryStream stream= new MemoryStream())
            {
                DataContractJsonSerializer serializer =
                    new DataContractJsonSerializer(typeof(customer));
                serializer.WriteObject(stream, this);
                stream.Flush();

                //Get the results of writing as a text
                stream.Seek(0, SeekOrigin.Begin);
                using(StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public customer FromJson(string json)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;

            //deserialize from the stream

            DataContractJsonSerializer serializer =
                new DataContractJsonSerializer(typeof(customer));
            customer cust = (customer)serializer.ReadObject(stream);
            return cust;
        }
    }
    class JsonSerialization
    {

        public static void add(int z, int y)
        {
            Console.WriteLine(z+y);
        }
        static void Main()
        {
            customer c = new customer()
            {
                Id = 10,
                Name="Banurekha",
                City="Chennai"
            };

            Console.WriteLine(c.Id + " "+ c.Name+ " "+ c.City);
            //call the function to serialize the above object into json 
            string jsondata = c.ToJson();
            Console.WriteLine(jsondata);

            //call the deserialize function

            customer c1 = c.FromJson(jsondata);
            Console.WriteLine(c1.Id+ " "+ c1.Name+ " "+ c1.City);
            //add(5, 5);
            Console.Read();
        }
    }
}
