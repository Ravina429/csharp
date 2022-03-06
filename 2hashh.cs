using System;
using System.Collections;
namespace hashh
{
    class programm
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "Ashish kumar");
            ht.Add("002", "Gita mehar");
            ht.Add("003", "Mayur shelkhe");
            ht.Add("004", "Vijay chakole");
            ht.Add("005", "kartik ingole");
            ht.Add("006", "Jyoti khadas");
            ht.Add("007", "Jyotsna Gawai");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name already in list ");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + " :" + ht[k]);

            }
            Console.ReadKey();

        }
    }
}