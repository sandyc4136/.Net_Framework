using System;
namespace Day_4
{
    // Employee class

    public class Employee
    {
        public int id;
        public string name;
        public int age;

        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public Employee()
        {

        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

    // Manaager class
    public class Manager
    {
        List<Employee> list = new List<Employee>();

        public Manager()
        {
            list.Add(new Employee() { id = 101, name = "Malkeet", age = 34 });
            list.Add(new Employee() { id = 103, name = "Ankit", age = 56 });
            list.Add(new Employee() { id = 104, name = "Priya", age = 22 });
            list.Add(new Employee() { id = 102, name = "Sohan", age = 36 });
        }

        public void AddEmployee()
        {
            Employee employee = new Employee();

            Console.WriteLine(" Enter Name of Employee");
            employee.name = Console.ReadLine();
            Console.WriteLine(" Enter Id of Employee");
            string temp = Console.ReadLine();
            employee.id = Convert.ToInt32(temp);
            Console.WriteLine(" Enter Age of Employee");
            temp = Console.ReadLine();
            employee.age = Convert.ToInt32(temp);

            list.Add(employee);

        }
        public void DeleteEmployee()
        {
            ShowEmployee();

            Console.WriteLine("Enter the Employee Id");
            string temp = Console.ReadLine();

            foreach (Employee emp in list)
            {
                if (emp.id == Convert.ToInt32(temp))
                {
                    list.Remove(emp);
                    Console.WriteLine("Record Deleted");
                    break;
                }
            }
            Console.WriteLine("List after Deleting a record");
            ShowEmployee();
        }

        public void UpdateEmployee()
        {
            ShowEmployee();

            Console.WriteLine("Enter the Employee Id to Uodate");
            string temp = Console.ReadLine();

            foreach (Employee emp in list)
            {
                if (emp.id == Convert.ToInt32(temp))
                {
                    Console.WriteLine("Enter Name:");
                    emp.name = Console.ReadLine();
                    Console.WriteLine("Record Updated");
                    break;
                }
            }
            Console.WriteLine("List after Updation a record");
            ShowEmployee();
        }

        public void ShowEmployee()

        {
            foreach (Employee e in list)
            {
                Console.WriteLine("Name:" + e.name + " id:" + e.id + " age:" + e.age);
            }
        }
    }
    public class Gen1
    {
        int a;

        void GetData(int c)
        {

        }
        //Generic Method
        public void SetData<T>(T u)
        {
            Console.WriteLine(u);
        }
    }
    public class Gen2<T>
    {
        //public int df;
        public T b;
        public Gen2(T b)
        {
            this.b = b;
        }
    }

    public class GenericAndCollection
    {
        public static void Main7()
        {
            Gen1 gen1 = new Gen1();
            Gen1 gen2 = new Gen1();

            gen1.SetData(100);
            gen1.SetData("Sandip");
            gen1.SetData('C');

            Gen2<String> g = new Gen2<string>("Malkeet");
            Gen2<int> g2 = new Gen2<int>(100);


            Console.WriteLine(g.b);
            Console.WriteLine(g2.b);

            // Collection - List

            List<String> slist = new List<string>();


            slist.Add("Sandip");
            slist.Add("Samikshya");
            slist.Add("Rushikesh");
            slist.Add("Sagar");

            foreach (var item in slist)
            {
                Console.WriteLine(item);
            }

           //  List<int> intlist = new List<int>();

        }
        public static void Main()
        {
            Manager m1 = new Manager();

            m1.ShowEmployee();

            m1.AddEmployee();
            // m1.DeleteEmployee();
            m1.ShowEmployee();

            //m1.UpdateEmployee();
        }
    }
}
