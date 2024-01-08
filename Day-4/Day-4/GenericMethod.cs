using System;
namespace Day_4
{
	public class Program1<T>
	{
		int a;
		public void showValues(T value)// Type parameter
		{
			Console.WriteLine(value);
		}
	}
	public class GenericMethod
	{
		static void Main10()
		{
			Program1<int> p = new Program1<int>();
			p.showValues(5);

            Program1<String> p1 = new Program1<String>();
            p1.showValues("Hello I am generic String");

        }
	}
}

