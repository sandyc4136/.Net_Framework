using System;
namespace Day_5
{
	public delegate void DGate1(int x, int y);  // Declaration of a Delegate
	internal class DeleDemo 
	{
		public void Add(int x, int y)
		{
			Console.WriteLine("Sum = " + (x + y));
		}
		public static void Main()
		{
			DeleDemo demo = new DeleDemo();

			DGate1 d1 = new DGate1(demo.Add); // Add is assigned to delegate d1

			d1(20, 40);
		}
	}
}

