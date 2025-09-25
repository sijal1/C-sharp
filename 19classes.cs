// purpose of a class constructor :
// initialize class fields. 
// automaticallu called when an instance of class is created

// constructor is not mandatory , if we do not provide a constructor,
// a default parameterless constructor is automatically provided 

// can be overloaded by the number and tyope of parameters


//DESTRUCTORS
// same name as class name , with ~ symbol in front
// dont take any parametrs and do not return values
//

using System;

class Customer
{
    string _firstName;
    string _lastName;


    //last part
    // you can write a constructor which does not take nay argument
    // this will be used when someone wants to use the class w/o any arguments

    public Customer() : this("NO FIRSTNAME", "NO LASTNAME")
    {
    
    }
    //

    //constructor to initialize the class fields 
    // it'll have same name as your class and parameters but no return type
    public Customer(string FirstName, string LastName)
    {
        // referring by its field 
        //  _firstName = FirstName;
        //  _lastName = LastName;

        //or use  'this'
        this._firstName = FirstName;
        this._lastName = LastName;

    }
    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0} ", this._firstName+" "+this._lastName);
    }

    //destructor , prefix : ~
    // same name as class , no parameters 
    // used to cleanup any resouces classs was holding
    ~Customer() { }
    // not necessary in c# since ,it is automatically called by garbage collector 
    // when it tries to clean object from memory 

    

}


 class Program
{
    static void Main(string[] args)
    {
        //instance of customer
        Customer C1 = new Customer("muhammad","sijal");
        //constructor is called automatically when we create a instacne of a class
        
        
        C1.PrintFullName();


        //a constructor is not always necessary
        //if you dont use constructor
        // you will get a constructor , w/o any parameters by .NET constr

        Customer C2 = new Customer();
        // you can rightclick  "Customer(); part and select definition to check where it is taking"
        C2.PrintFullName();
    }
}

// this is called overloading constructors
//the class has 2 constructors - 1. no parametrs 2. with two parametrs




