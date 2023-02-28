using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day7prj
{
    //using delegates, we wuld like to print some data onto the screen as well as a file
    public delegate void PrintDelegate(string s);
    class Files_DelegatesEg
    {
        static FileStream fs;  //like a paper or book to write
        static StreamWriter sw; //like a pen to write to a stream

        public static void WriteTo_Screen(string str)
        {
            Console.WriteLine("{0}", str);
        }

        public static void WriteTo_File(string s)
        {
            fs = new FileStream("messagefile.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendData(PrintDelegate pd)
        {
            pd("Take the string and write it ..");
        }

    }

    class TestDelegate
    {
        static void Main()
        {
            PrintDelegate pd1 = new PrintDelegate(Files_DelegatesEg.WriteTo_Screen);
            PrintDelegate pd2= new PrintDelegate(Files_DelegatesEg.WriteTo_File);
            Files_DelegatesEg.SendData(pd1);
            Files_DelegatesEg.SendData(pd2);
            Console.Read();
        }
    }
}
