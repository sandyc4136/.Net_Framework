using System;
namespace Day_4
{
    interface A
    {
        void showA();
    }
    interface B:A
    {
        void showB();
    }
    public class Interface_inheritance:B 
	{
        
        static void Main3()
		{
            Interface_inheritance obj = new Interface_inheritance();
            //obj.show(); // error
            obj.showA();
            obj.showB();
        }

        public void showA()
        {
            Console.WriteLine("Interface A method");
        }
        public void showB()
        {
            Console.WriteLine("Interface B method");
        }

        
    }
}

