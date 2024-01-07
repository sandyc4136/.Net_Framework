namespace Day
{
    interface IntOne
    {
        // Properties , static methods, Indexers, static variable(private , protected, internal)
        void Display();
         void Show() // Default method
        {
            Console.WriteLine("Hello I am Default");
        }
    }

    interface IntTwo
    {
        void Display(int a);
    }
     
    public class IntDemo : IntOne, IntTwo
    {
        //  Implicit interface implementation
        public void Display()
        {
            Console.WriteLine("Display ");
        }
        public void Display(int a)
        {
            Console.WriteLine("Display with one argument ");
        }

        //  Explicit interface implementation
        //void IntOne.Display()
        //{
        //    throw new NotImplementedException();
        //}

        // void IntTwo.Display(int a)
        //{
        //    throw new NotImplementedException();
        //}
    }
    internal class Program
    {
        static void Main1()
        {
            IntDemo ob = new IntDemo();
            ob.Display();
            ob.Display(10);
            // ob.Show();  // Default method of Parent interface is not visible to the derived interface, instead do the below
            IntOne IO = ob;
            IO.Show();
        }
    }
}