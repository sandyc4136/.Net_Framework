using System;
namespace Day_3
{
	public class StaticMembers
	{
		static int x = 3; // Static variable
		int y = 4; // static method

		 static void Main1()
		{
			Console.WriteLine("static variable x = " + x);
			//int a=sum(x);
			StaticMembers obj = new StaticMembers();
			Console.WriteLine(" Non static variable y =" + obj.y);
            Console.WriteLine(StaticMembers.sum(x));

        }
		static int sum(int a) // static Method
		{
			return a + 10;
		}
	}
}

namespace FirstConsoleApp
{
	class Program
	{
		static int empID;
		public static int EmpID
		{
			get => empID;
			set => empID = value;
		}

		static void Main1()
		{
			Program.EmpID = 101;
			Console.WriteLine(Program.EmpID);
		}
	}
}

