using System;
namespace Day_4
{
    public class ClassOne
    {
        public int a;
        public int b;
        public ClassOne()
        {

        }
        public ClassOne(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        //public return_type (Class) operator+(ClassOne ref)
        public static ClassOne operator +(ClassOne ob, ClassOne ob2)
        {
            ClassOne classOne = new ClassOne();

            classOne.a = ob2.a + ob.a;
            classOne.b = ob2.b + ob.b;

            return classOne;

        }
        public void Display()
        {
            Console.WriteLine("a=" + a + ", b=" + b);
        }

        //Unary operator: can and cant
        //Binary operator: can and cant

    }
    internal class OpOverDemo
	{
        public static void Main3()
        {
            ClassOne c1 = new ClassOne(1, 2);
            ClassOne c2 = new ClassOne(2, 3);

            ClassOne c3 = new ClassOne();
            c3 = c1 + c2;
            c3.Display();

        }
    }
}

