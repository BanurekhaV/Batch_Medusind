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
            ArrayList alist1 = new ArrayList();
            alist1.Add(10);
            alist1.Add("Hello");
            alist1.Add('b');
            alist1.Add(106.5f);
            alist1.Add(false);

            foreach(var item in alist1)
            {
                Console.WriteLine(item);
            }

            ArrayList al2 = new ArrayList();
            al2.Add(78);
            al2.Add(2);
            al2.Add(24);
            al2.Add(10);


            al2.Sort();

            foreach(int x in al2)
            {
                Console.WriteLine(x);
            }

            Console.Read();

        }

    }
}
