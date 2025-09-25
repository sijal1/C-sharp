// interfaces

using System;

interface ICustomer1
{
    // int id = 1;   //interface cannot have fields 
    void Print1();
}

interface ICustomer2
{
    void Print2();
}

class Customer : ICustomer1, ICustomer2  //class can inherit interface , but they must provide implementation for interface member
{
    public void Print1() // the method shouyld be same , even adding an argument
    {
        Console.WriteLine(" Print 1 method ");
    }
    public void Print2() //if a class inherits a interface , and that interface inherits another interface 
                          //  it must provide implementation for both interface bodies
    {
        Console.WriteLine("Print 2 method ");
    }
}
 class Program
{
    static void Main(string[] args)
    {
        Customer c = new Customer();
        c.Print1();
        c.Print2 ();

        // we cannot create an instance of an interface 
        // -- because theres no implmentation on interfaces 

        // what you can do is 
        ICustomer1 IC1 = new Customer();
        IC1.Print1();

        // here IC1 is reference variable of type ICustomer1
        // and is  pointing to drived class object 

    }
}

