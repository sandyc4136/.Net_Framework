## .NET Notes Day-5 Date: 06/01/2024
#### Interfaces
- It is a blueprint of the class.
- If an interface have only one abstract method that interface is know as Functional Interface
- Implementing an interface
```C#
using System.Runtime.CompilerServices;

namespace Day_4Sept23
{
    interface IntOne
    {
        //Properties, static methods, Indexers, static variable (private, protected, internal)
        void Display();   //public abstract 
        //Default Method
        void Show()
        {
            Console.WriteLine("Hello Am Default");
        }
    }
    interface IntTwo
    {
        void Display( int a);

    }

    public class IntDemo : IntOne, IntTwo
    {
        //Explicit interface implementation
        // void IntOne.Display()
        // {
        //     throw new NotImplementedException();
        // }

        //void IntTwo.Display(int a)
        // {
        //     throw new NotImplementedException();
        // }
        public void Display()
        {
            Console.WriteLine("Display");
        }

        public void Display(int a)
        {
            Console.WriteLine("Display with one");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           IntDemo ob = new IntDemo();

        ob.Display();
        
        IntOne o= ob;  //Object Up-casting
        o.Show(); //Default method of IntOne interface is being called for object of IntDemo class.          
        }
    }
}
```
- Explicitly implementing an interface
- Inheritance in interfaces
- Default interface methods 
#### Operator overloading
- If we are using one operator for two or more purposes.
- == <> Generic
#### Reference and Value Types 
- Value Types
    - int, char, float, double, struct , enum
    - class, interface, array 
- strut
    - Please do by yourself
- enum 
    - Please do by yourself
- out and ref 
- nullable types 
- nullable reference types 
- ?? and ??= : Do by yourself
- Working with Arrays (single, multidimensional, jagged), Array Class members 
- Indices and ranges 
- Indexers: 
    - It is a property by which we can access objects like arrays
#### Generic Programming
- Our methods and classes are bounded to have only on type of data.
- Generic Classes
- Generic methods 
- Generic Constraints/Restrictions: Read by yourself
#### Collections 
- namespace System.Collections (old one)
- Generic : Type Safety, it means your can collect objects only of type defined
    - List
    - Stack
    - Queue
    - LinkedList
    - SortedSet
    - Dictionary<K,V>
    - SortedList
    - namespace System.Collection.Generic
- foreach, for each method (using lambdas)
- interface : IComparable, IComparator    
- Non-Generic Collection
    - namespace System.Collection.NonGeneric
- Concurrent Collection: Thread Safety
    - namespace System.Collection.Concurrent
- Examples based on ICollection, IList, IDictionary (both generic and non-generic)
- Iterating collections using foreach 
- Using Tuples to pass multiple values to a function,
- Enumerator: to traverse a collection
- DataType->Array->Struct->class->ArrayOfObject->Collection
- Implementation of IComparable, IComparer, IEquitable : Will be implemented later
#### Delegates, LINQ , Partial Classes (Advanced C#)
- Delegate are reference type to the method.
- Delegate is a pointer/Ref to a method instead of variable
```C#
D
void Add(int x, int y)
{
    //do something
}

D=add;  //D will be treated as Delegate

```
- Steps to use the Delegates
    1. Declaration of Delegate
        - Outside of class (Recommended)
        - inside the class
        - syntax: public delegate void DGate1(int x, int y);
    2. Assigning a method
    3. Calling that method by using delegate
        - call the method with ref variable of delegate without function name.
- Calling methods using delegates 
- Uses of delegates 
- Multicast delegates 
- Action
- Func
- Predicate delegates 
- Anonymous methods 
- Lambdas