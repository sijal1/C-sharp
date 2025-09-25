
// we cant have multople class inheritance in c#
// but it is possible by using interfaces ,indirectly

using System;
using System.Runtime.InteropServices;

interface IA
{
    void AMethod();
}

class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}
// another interface and class
interface IB
{
    void BMethod();
}

class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}

// class AB , tries to inherit both A and B(error: class AB cannot have multiple base classes)
// class AB : A, B     is not possible so  

class AB : IA, IB
{
    // but you dont have to provide implementation here, since there
    // class A and class B has already implemented them , so you can 

    A a = new A();
    B b = new B();
    public void AMethod()
    {
        a.AMethod();  // has the functionality of a method
                      // but we are not implementing here
                      // we are proving implementation from class A, so to use this (goto main)
    }
    public void BMethod()
    {
        b.BMethod();
    }
}


    class Program
{
    static void Main(string[] args)
    {
        //create instance of class AB
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}
