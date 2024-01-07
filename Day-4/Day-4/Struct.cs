using System;
namespace Day_4
{
	 struct One
	{
		int value;
		string name;
	}

	internal class Struct
	{
		//public static void Method1(ref int a)
		public static void Method1(out int a)
        {
			a = 0;
			Console.WriteLine("value received = "+ a);
			a = 50;
			
		}
		public static void Main1()
		{
			One s = new One();
		}
        public static void Main3()
        {
			int b = 30;
			// Struct.Method1(b); // pass by value
			// Struct.Method1(ref b); // pass by reference 
            //Console.WriteLine("value of b after passing to Method1 = "+ b);

			// Use of out variable
            int c;
			Struct.Method1(out c);
            Console.WriteLine("Value of c after c passing to method1=" + c);

        }

        public static void Main4()
        {
            //int d = null;  // not possible before declaring nulllable

			//  two ways to make a variable of type null
            int? d = null;  //d is int variable but it can store null as value
            Nullable<float> f = null;  //making nullable type using Nullable<>

            Console.WriteLine("value of f without initializing = "+ f.GetValueOrDefault()); //It will print assigned value or in case of null it will print 0
            Console.WriteLine("value of d without initializing = " + d.GetValueOrDefault());

            d = 7;
			f = 4.5f;

            Console.WriteLine("value of d after initializing = " + d);
            Console.WriteLine("value of f after initializing = " + f); // In case of no numeric value is assigned to d it will print nothing
        }

        public static void Main7()
		{
            static void reffunction(ref int x)
            {
                x = 40;
            }
            static void outfunction(out int y)
            {
                y = 50;
            }
            static void Main6()
            {
                int r = 30; // compiler error if no value assigned
                int o;
                reffunction(ref r);

                outfunction(out o);

                Console.WriteLine("ref variable = " + r);
                Console.WriteLine("out variable = " + o);
            }
        }
    } 

}

