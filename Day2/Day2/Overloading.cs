using System;
namespace Day_2
{
	 class Overloading
	{

		public static int Add(int x, int y)
		{
			Console.WriteLine("X = " + x + " Y = " + y);
			int sum = x + y;
			return sum;
		}
        static void Main(string []args)
        {
			
            Console.WriteLine("Result " + Overloading.Add(10, 20));
        }
    }

	
}

