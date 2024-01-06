namespace Day3
{
    internal class Program
    {
        static void Main4(string[] args)
        {
            StaticCons cl = new StaticCons(); // 
            StaticCons c2 = new StaticCons();
            // Static variables are initialized only once , hence once only static constructors are called


            // 1. Static constructor will get invoked just before the normal constructor
            // 2. Static constructor will get invoked just before the reference to a Static variable/ data member;
            // 3. Static Constructor cannot be invoked explicitly, only CLR or execution engine can call/ invoke hence
            //      Static Constructor cannot be defined with any access modifier 

            Console.WriteLine("C = " + StaticCons.c);

        }
        
        static void Main3()
        {
            // Object Initializer block
            StaticCons ob1 = new StaticCons()
            {
                a = 50,
                b = 60
            };
            StaticCons ob2 = new StaticCons()
            {
                a = 200,
                b = 360
            };
            StaticCons ob3 = new StaticCons()
            {
                a = 400,
               
            };
            ob1.Display();
            ob2.Display();
            ob3.Display(); // a=400 and b=0 , because first default constructor is called and intialized default_values(0) to the variables
        }
    }
    public class StaticCons
    {
        public int a;
        public int b;
        protected internal int d; // accessible with base and child both class object in child class.
        // protected  int d; // inaccessible in child class with base class object , we need to call using child class object only. 
        public StaticCons()
        {
            Console.WriteLine("I am the default Cons");
        }
        public static int c;

        static StaticCons()
        {
            c = 101;
            Console.WriteLine("I am static cons");
        }
        public void Display()
        {
            Console.WriteLine("a = " + a + " and b = " + b + " d = " + d);
        }
    }
}