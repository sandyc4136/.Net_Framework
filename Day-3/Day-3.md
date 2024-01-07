
#### Day 3 
    
#### Static Constructors
- 







#### Static Classes,
- Static class declared using static keyword.
- Static class can consist only static members (Data or methods).
- Static class can not be initiated (it can't have objects).

#### Inheritance 
- It is OOPs feature which support code re-usability.

#### Types of Inheritance
1. Single Level
2. Multi-Level
3. Hybrid
4. Hierarchical
5. Multiple: (Through interfaces)

#### Access Modifiers
- public 
    - accessible any where.
- protected 
    - accessible within the same file / project through inheritance, but outside the assembly it is not accessible (it becomes private).
- private ( completely private )
- internal 
    - assembly level private / i.e. we can access outside of the class , even outside of the file without inheritance but  within a project only.
    - Data members or member functions can not be accessed outside of the assembly.
- protected internal
    - Data members or member functions can be accessed outside the assembly only if the class is being inherited in another assembly.

#### Inheritance COncepts
- In java
- In C# we use "override" keyword 


    ## Binding
    - Early Binding / Static / CompileTime Polymorphism
    - Late Binding  / Dynamic Method Dispatch / Runtime Polymorphism / Dynamic binging :
        - Inheritance must be done
        - There should be Overriding
        - The Overridden method should be declared virtual inside base class.
        - There should be object Up-casting.

- Sealed Methods,
    - Base class method can't be sealed. It always happen at child class
    - any derived class can make a overridden method as sealed.
    - sealed method can't overridden at further level of inheritance.

#### Abstraction
    - Data Abstraction (Data Hiding) : by using access modifiers :    Data Encapsulation

- Abstract Classes
    - Which are declared using 'abstract' keyword.
    - These classes can have abstract methods as well as non-abstract methods.
    - These classes can't be initiated ( we can't create it's objects ).
    - We use this to achieve certain level of abstraction in the code.

- Abstract Methods 
    - The methods which are declared using keyword 'abstract'.
    - If a method is declared as 'abstract' inside the class then that class must be 'abstract'.
    - abstract method have no body.
    - its implementation is done in derived classes.
- if a class inheriting a 'abstract' class then it should give definition to all its abstract method.

#### Interfaces
- It is a blueprint of the class.
- If an interface have only one abstract method that interface is known as Functional Interface.
- Implementing an interface
- Explicitly implementing an interface
- Inheritance in interfaces
- Default interface methods 


