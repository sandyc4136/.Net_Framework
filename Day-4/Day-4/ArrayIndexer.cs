using System;
namespace Day_4
{
    public class Student
    {
        public int id;
        public string name;
        public string age;

        public Student(int id, string name, string age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

    internal class ArrayIndexer
	{
        Student[] slist = new Student[3];  //collection of student is a instance variable for ArrayIndexer


        //Indexer it is a property defined inside a class to access its collection of objects like an Array
        public Student this[int i]
        {
            get
            {
                return slist[i];
            }
            set
            {
                slist[i] = value;
            }
        }
        public static void Main5()
        {
            ArrayIndexer obj = new ArrayIndexer();

            obj[0] = new Student(101, "Sunil", "30");
            obj[1] = new Student(102, "Sandip", "30");
            obj[2] = new Student(103, "Soham", "30");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(obj[i].id + " " + obj[i].name + " " + obj[i].age + " " );
                
            }

        }
    }
}

