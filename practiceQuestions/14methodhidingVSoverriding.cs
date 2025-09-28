

//Write a program to demonstrate method hiding vs overriding when calling methods using a base class reference. 

using System;
using System.Xml.Serialization;

public class Baseclass 
{
    public virtual void Print() 
    {
        Console.WriteLine("base print method ");
    }
}
public class DerivedClass1 : Baseclass
{
    public override void Print()  // Overriding the base class method
    {
        Console.WriteLine("derived  class method : overriding");
    }
}

public class DerivedClass2 : Baseclass
{
    public new void Print()  // Hiding the base class method
    {
        Console.WriteLine(" derived class :  hiding method "); 
    }
}



class Program
{
    public static void Main(string[] args)
    {
        Baseclass b1 = new DerivedClass1();  // Base class reference pointing to DerivedClass1
        b1.Print();                             // Calls overridden method

        Baseclass b2 = new DerivedClass2();   // Base class reference pointing to DerivedClass1
        b2.Print();                             // Calls base class method (hiding doesn't affect base reference)

        DerivedClass2 d2 = new DerivedClass2();  // Derived class reference pointing to DerivedClass2
        d2.Print();                              // Calls hidden method
    }
}
