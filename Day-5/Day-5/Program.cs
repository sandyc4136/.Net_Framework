
using System.Collections;

namespace Day5
{
    public class Employee
    {
        public int id;
        public string name;

        public override string? ToString()
        {
            return "Id=" + id + " Name=" + name;
        }
    }

    public class Address
    {
        public int Flatno;
        public string City;
        public string Region;
        public string PostalCode;
    }

    internal class Program
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(100);
            list.Add(100);
            list.Add(100);
            list.Add(100);

            //foreach (int a in list)
            //{
            //    Console.WriteLine(a);
            //}

            Dictionary<String, int> map = new Dictionary<String, int>();

           // map.Add("Malkeet", 10);


            SortedList slist = new SortedList();

            slist.Add(10, new Employee() { id = 101, name = "Deepak" });
            slist.Add(20, new Employee() { id = 102, name = "Piyush" });
            slist.Add(30, new Employee() { id = 103, name = "Neeraj" });
            slist.Add(40, new Employee() { id = 104, name = "Pawan" });

            //ICollection<Employee> elist = new List<Employee>();
            //foreach (Employee e in elist)
            //{
            //    Console.WriteLine( "Id : "+  e.id + "    Name : " + e.name);
            //}

            foreach (DictionaryEntry d in slist)
            {
                Console.WriteLine("Key=" + d.Key + "    Value" + d.Value.ToString());
            }

            //Hashtable ht = new Hashtable();

            //ht.Add(100, "Malkeet");
            //ht.Add("ABC", 345.789);

            //foreach (DictionaryEntry d in ht)
            //{
            //    Console.WriteLine("Key:" + d.Key + " value associated with it=" + d.Value);
            //}


        }
    }
}