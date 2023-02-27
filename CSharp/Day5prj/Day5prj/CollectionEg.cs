using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day5prj
{
    class CollectionEg
    {
        static void Main()
        {
            // ArrayListEg();
            HashTableEg();
            SortedListEg();
            Console.Read();
        }
        public static void ArrayListEg()
        {
            ArrayList alist1 = new ArrayList();
            alist1.Add(10);
            alist1.Add("Hello");
            alist1.Add('b');
            alist1.Add(106.5f);
            alist1.Add(false);

            foreach (var item in alist1)
            {
                Console.WriteLine(item);
            }

            ArrayList al2 = new ArrayList();
            al2.Add(78);
            al2.Add(2);
            al2.Add(24);
            al2.Add(10);

            alist1.InsertRange(1, al2);
            alist1.Remove(2);  //giving a value to remove from the collection
            alist1.RemoveAt(3); //4th element of the collection will be removed
            al2.Sort();

            foreach (int x in al2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-----------------");
            foreach (var item in alist1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count : " + alist1.Count);
            Console.WriteLine("Capacity : " + alist1.Capacity);
        }

        public static void HashTableEg()
        {
            Hashtable ht = new Hashtable();

            //keys and values can be of different daya types
            //Keys cannot be null, but values can be
            //keys cannot be duplicated, but values can be
            ht.Add("E005", "Harish"); 
            ht.Add("E002", "Kailash");
            ht.Add("E004", "Prema");
            ht.Add("E001", "Janani");
            ht.Add("E003", "Gayathri");
            ht.Add("E007", 's');
            ht.Add(6, "Jayanth");

            //iterating the collection using keys
            foreach(var s in ht.Keys)
            {
                Console.WriteLine(s);
            }

            //iterating the collection using Values
            foreach (var s in ht.Values)
            {
                Console.WriteLine(s);
            }

            //iterating the collection using both keys and values
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key + " ");
                Console.Write(de.Value);
                Console.WriteLine();
            }

            //to search the hashtable with huge records
            Console.WriteLine("Enter a key to search :");
            string eid = Console.ReadLine();
            if(ht.ContainsKey(eid))
            {
                Console.WriteLine(eid + "=" +  ht[eid]);
            }
            else
                Console.WriteLine(eid + " "+ "key does not exist");
        }
        public static void SortedListEg()
        {
            SortedList sl = new SortedList();
            sl.Add("vb", "Visual Basic");
            sl.Add("asp", "Asp.Net");
            sl.Add("cs", "CSharp");
            sl.Add("sql", 4);

            foreach(var item in sl.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
