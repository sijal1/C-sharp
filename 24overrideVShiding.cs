using System;


public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine(" base class print method ");
    }
}

public class DerivedClass: BaseClass
{
    public override void Print()
    {
        Console.WriteLine(" Derived class print method ");
    }
}

public class DerivedClass2 : BaseClass
{
    public new void Print()
    {
        Console.WriteLine(" Derived 2 class print method ");
    }
}

public class Program
{
    static void Main(string[] args)
    {
       // base class ref points to derived class object, and at runtime 
       // so it will print overriden method inspite ref var being of type base   base class method 
       // thast overriding 
        BaseClass B = new DerivedClass();
        B.Print();


        // here since the variable is of type base class
        // the base class method will be called
        BaseClass B2 = new DerivedClass2();
        B2.Print();


        // method overriding -  "virtual + override" keyword
        //  base class ref -->  derived class obj
        //                        will call overridden method (child )


        // method hiding  - "new" keyword
        //  base class ref -->  derived class obj
        //                        will invoke hidden method in base class
    }
}

