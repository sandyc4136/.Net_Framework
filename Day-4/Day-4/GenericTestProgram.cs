using System;
namespace Day_4
{
	// Generic class
	public class Program<T> where T : IComparable
	{
		public T data;
		public string process(T input)
		{
			if (data.CompareTo(input) == 0)
				return "Same";
			else
				return "Not Same";
		}
	}
	// Non-Generic class
	public class Program
	{
		public object data;
		public string process(object input)
		{
            if (data==input)
                return "Same";
            else
                return "Not Same";
        }
	}
	public class GenericTestProgram
	{
		// Main for Generic class
		static void Main8()
		{
			Program<int> p = new Program<int>();
			p.data = 32;
			Console.WriteLine(p.process(32));

            Program<String> p1 = new Program<String>();
            p1.data = "Apple";
            Console.WriteLine(p1.process("Apple"));
        }

        // Main for Non-Generic class
        static void Main9()
        {
            Program p = new Program();
            p.data = 32;
            Console.WriteLine(p.process(32));

            Program p1 = new Program();
            p1.data = "Apple";
            Console.WriteLine(p1.process("Apple"));
        }
    }
}

