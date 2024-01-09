using System;
using System.Collections;

namespace Day6
{
    internal  class Program
    {
        // List<T>
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(200);
            list.Add(400);
            list.Add(600);
            list.Add(800);
            list.Add(1000);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }

        // Dictionary<TKey, TValue>
        static void Main2(string[] args)
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("Name :", "Sandip");
            items.Add("Age :", "28");
            items.Add("Qualification :", "B. tech");
            foreach(KeyValuePair<string, string> i in items)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }

        // HashTable
        static void Main3(string[] args)
        {
            Hashtable set = new Hashtable();
            set.Add(1, "Sandip");
            set.Add(2, 101);
            set.Add(3, "India");
            set.Add(4, null);
            foreach(DictionaryEntry s in set)
            {
               Console.WriteLine(s.Key + " " + s.Value);
            }
        }

        // ArrayList
        static void Main(string[] args)
        {
            ArrayList Aset = new ArrayList();
            Aset.Add("Sandip");
            Aset.Add(101);
            Aset.Add("India");
            Aset.Add(null);
            foreach (Object a in Aset)
            {
                Console.WriteLine(a);
            }
        }

    }
}

 