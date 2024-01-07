using System;
namespace Day_3
{
    // This is a Functional Interface ( which has only one Abstract function )
    interface FuncInterface
    {
        void Method2();
    } 



	interface Int1
	{ 
		void ShowData(); //this is same as  "abstract public void ShowData();"
        void GetData();

        void Method3()  // the method which we don't want to implement in the derived class but in the main class then we can write the definition here only
        {
            Console.WriteLine("Method3");
        }

	}
    public class Class1 : Int1
    {
        public void GetData()
        {
            Console.WriteLine("GetData");
        }

        public void ShowData()
        {
            Console.WriteLine("ShowData");
        }
    }

    internal class InterFace
	{
		public static void Main()
        {
            Class1 c1 = new Class1();
            c1.GetData();
            c1.ShowData();
            // c1.Method3();
        }
	}
}

