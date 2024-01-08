using System;
namespace Day_4
{
	public class Program2<T> where T : class
	{
		public void showValues(T value) // Type Parameter
		{
			Console.WriteLine(value);
		}
	}
	public class GenericConstraints
	{
		static void Main11()
		{
			// Program2<int> p1 = new Program2<int>(); // error as it is a value type
			// p1.showValues(10);

			Program2<String> p2 = new Program2<String>();
			p2.showValues("India");
		}

	}
}

namespace Day_44
{
    public class Program2<T> where T : struct
    {
        public void showValues(T value) // Type Parameter
        {
            Console.WriteLine(value);
        }
    }
    public class GenericConstraints
    {
        static void Main()
        {
            Program2<int> p1 = new Program2<int>(); 
            p1.showValues(10);

            // Program2<String> p2 = new Program2<String>(); // error as it is a reference type
            // p2.showValues("India");
        }

    }
}

