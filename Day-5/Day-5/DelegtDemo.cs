using System;
namespace Day_5
{
	public delegate void DGate1(int x, int y);  // Declaration of a Delegate

    public delegate void DGate2();

    public class FunDel
    {
        public bool CheckAge(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            return false;
        }
        public int Method1()
        {
            return 100;
        }
        public int Method2(int x)
        {
            return 200;
        }
        public void Method3()
        {
            Console.WriteLine("Hello");
        }
    }

    internal class DeleDemo 
	{
		public void Show()
		{
            Console.WriteLine("Show ");
        }
        public void Show1()
        {
            Console.WriteLine("SHow1");
        }
        public void Show2()
        {
            Console.WriteLine("SHow2");
        }
        public void Show3()
        {
            Console.WriteLine("SHow3");
        }
        public void Add(int x, int y)
		{
			Console.WriteLine("Sum = " + (x + y));
		}
		public static void Main2()
		{
			DeleDemo demo = new DeleDemo();

			DGate1 d1 = new DGate1(demo.Add); // Add is assigned to delegate d1

            // OR

            DGate1 dGate1 = demo.Add;  //another way to assign a method to the delegate

            d1(20, 40);
            DGate2 d2 = new DGate2(demo.Show);
            d2 = d2 + demo.Show1;  //Multi-Cast Delegate it is holding more than one function at same time. single call required (i.e. d2())
            //d2+= demo.Show2 + demo.Show3; // can't write like this , instead write
            d2 += demo.Show2;
            d2 += demo.Show3;
            d2();
        }

        public static void Main3()
        {
            FunDel f1 = new FunDel();

            Func<int> f = f1.Method1;

            int x = f();

            // Console.WriteLine(x);

            Func<int, int> f2 = f1.Method2;


            Action a1 = f1.Method3;
            //a1();

            Predicate<int> p1 = f1.CheckAge;

            Console.WriteLine(p1(18));
        }

        public static void Main ()
        {
            Action a1 = delegate ()
            {
                Console.WriteLine("Hello Am ghost");
                Console.WriteLine("Hello Am ghost");
                Console.WriteLine("Hello Am ghost");
                Console.WriteLine("Hello Am ghost");
            };
            a1();

            Action a2 = () =>
            {
                Console.WriteLine("Hello am Lambda");
            };


            Action<int, int> a3 = (int x, int y) =>
            {
                Console.WriteLine(x + y);
            };

            // a2();

            a3(20, 30); 
        }
	}
}

