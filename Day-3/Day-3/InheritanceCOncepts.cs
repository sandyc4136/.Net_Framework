using System;
namespace Day_3
{
	public class InheritanceCOncepts
	{ 
		public static void Main4(string []args)
		{
			Second s1 = new Second();
			s1.Method1();

			// When we use base class ref variable and derived class object inside it,
			// if we call Method2 it will bind its base class definition. Because of Early binding.

			// Early binding is always done by seeing the type of reference variable. Early binding is done by the compiler.
			First f = new Second(); // Object upcasting
			f.Method2(); // it will bind base class definition.
			s1.Method2();
			
		}
	}
	public class First
	{
		public void Method1()
		{
			Console.WriteLine("Method1 by First");
		}
		// Overloading of Method1
        public void Method1(int a)
        {
            Console.WriteLine("Method1 by First with parameter");
        }
		// here Method2 is declared as virtual so that it can be overridden
		 virtual public void Method2()
		{
            Console.WriteLine("Method2 by First ");
        }
    }
	public class Second : First
	{
		// here new keyword is used to hide the definition of Method1 which is coming from class First
		new public void Method1()
		{
            Console.WriteLine("Method1 by Second");
        }
		// Method overriding
         override public void Method2()
        {
            Console.WriteLine("Method2 by Second");
        }
    }
}

namespace Sealed
{
	public class SealedDemo
	{

	}

	// ABC is sealed class which can't be inherited
	sealed public class ABC
	{
		int a;
		int b;
	}
	 public class SealOne // : ABC // not Ok because ABC is sealed.
	{
        virtual public void Display()
		{
			Console.WriteLine("I am Display() of SealOne");
		}
	}
    public class SealTwo : SealOne
    {
         sealed override public void Display()
        {
            Console.WriteLine("I am Display() of SealOne");
        }
    }

  //  public class SealThree : SealTwo
  //  {
		//// Here method Display is sealed by Class SealTwo so it can't be overridden in SealThree
  //      override public void Display() // this will fetch an error
  //      {
  //          Console.WriteLine("I am Display() of SealOne");
  //      }
  //  }
}

namespace Abstact
{
	public class AbstractDemo
	{
		public static void Main3()
		{
			AbsInherit a1 = new AbsInherit();
			a1.AbsMethod();
			a1.a = 2; // a was declared inside the abstract class but it is being utilized for the object of AbsInherit
			a1.Meth1();
		}
	}
	abstract public class AbsOne
	{
		public int a;
		static int b;
		public static void Method()
		{

		}

		abstract public void AbsMethod();
        // abstract public void AbsMethod1(); //this too need to be implemented in the derived class

		public void Meth1()
		{
            Console.WriteLine( " I am the public method in Abstract class AbsOne");
        }

}
	public class AbsInherit : AbsOne
	{
		
        // Class AbsInerit is overriding abstract method AbsMethod of class AbsOne
        override public void AbsMethod()
		{
			Console.WriteLine("I am the Abstract method overridden by AbsInherit");
		}
	}

}

