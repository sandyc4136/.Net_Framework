using System;
using Day3;

//namespace Day_3
//{
//	internal class AccessMod : StaticCons
//	{
//        public AccessMod()
//        {
//            Console.WriteLine("I am default constructor");
//        }
//        public AccessMod()
//        {
//            Console.WriteLine("I am 1-argument constructor");
//        }
//        public AccessMod(int a, int b): this(30)
//        {
//            Console.WriteLine("I am 2-arguement constructor");
//        }
//        public static void Main(int a, int b)  : this(10)
//        {
//            AccessMod ob1 = new AccessMod(10,30);
//        }

//        public static void Main1()
//        {
//            //StaticCons d1 = new StaticCons();
//            //d1.d = 4;
//            //d1.Display();
//            AccessMod c1 = new AccessMod();
//            c1.d = 9;
//            c1.Display();
//        }

//    }

//}

namespace Day3
{
    public class A
    {
        public A()
        {

            Console.WriteLine("A");
        }
        ~A()
        {
            Console.WriteLine("Des of A");
        }
    }
    public class B : A
    {
        public B()
        {

            Console.WriteLine("B");
        }
        ~B()
        {
            Console.WriteLine("Des of B");
        }
    }
    public class C : B
    {
        public C()
        {

            Console.WriteLine("C");
        }
        ~C()
        {
            Console.WriteLine("Des of C");
        }
    }
    public class D : C
    {
        public D()
        {

            Console.WriteLine("D");
        }
        ~D()
        {
            Console.WriteLine("Des of D");
        }

    }
    internal class AccessMod : StaticCons
    {
        public static void Main5()
        {
            D d = new D();
        }
    }
}

// Constructor --> Ascending order ( A, B, C, D )
// Destructor --> Descending order ( D, C, B, A )