using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDayFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(1, "Ahmet");
            ogrenci.Add(2, "Kadir");
            ogrenci.Add(3, "Kenan");
            Console.WriteLine(ogrenci.Count);
        }
    }

    class MyDictionary<Type1, Type2>
    {
        Type1[] keys;
        Type2[] values;

        Type1[] tempKeys;
        Type2[] tempValues;

        public MyDictionary()
        {
            keys = new Type1[0];
            values = new Type2[0];
        }
        public void Add(Type1 item1, Type2 item2)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new Type1[keys.Length + 1];
            values = new Type2[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = item1;
            values[values.Length - 1] = item2;
        }

        public int Count
        {
            get { return keys.Length; }
        }
    }
}
