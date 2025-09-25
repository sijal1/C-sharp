//abstract classes

using System;
using System.Runtime.InteropServices;

public abstract class Customer 
{
    //any abstract member cannot have an implemetation 
    public abstract void Print();
}

// when a non-abstract class inherits abstract class 
// then non-abstarct class has to provode implementations for all abstarct methods/members within base class


// if we do NotFiniteNumberException wish to provide implementation then
//  we can mark this class abstract as well
//
//  public abstract class Program : Customer
//  {  }

 public class Program : Customer
{
    // to implement , we have to use "override" keyword 
    public override void Print()
    {
        Console.WriteLine("print method");
    }
    static void Main(string[] args)
    {
        // you can create object of customer type or 

        // parent class ref veriable  - pointing to derived class object  
        Customer C = new Program();
        C.Print();
    }
}


