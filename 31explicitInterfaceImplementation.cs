// explicit interface imlpementation

using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;

interface I1 
{
    void InterfaceMethod();
}

//(1) consider scenario ; another interface having method having exactly 
// similar to I1 , and the class is inheriting from interfaces
// (only 1 implementation in body ATP)
// it doesnt show any error - class inherit 2 interface ; and implents 1 method (same name)
// the visual studio thinks, we implenented both interface methds
interface I2
{
    void InterfaceMethod();
}

interface I3
{
    void InterfaceMethod();
}


class Program : I1, I2
{
    // 1. when explicitly implementing interface member , you are not allowed to use access modifiers
    // 2 . you have to ; interface_name.method_name
     
    void I1.InterfaceMethod() 
    {
        Console.WriteLine("I 1 INTERFACE METHOD ");
    }
     void I2.InterfaceMethod()
    {
        Console.WriteLine("I 2 INTERFACE METHOD "); 
    }

    // (last part)making i3 default
    public void InterfaceMethod()
    {
        Console.WriteLine("default 13 INTERFACE METHOD ");
    }
   


    static void Main(string[] args)
    {
        Program P = new Program();
        
        // P.InterfaceMethod(); // gives error(when nothing is default )

        // only way to invoke a explicit interface member 
        ((I1) P).InterfaceMethod();
        ((I2) P).InterfaceMethod();

        // other way is 
        I1 i1 = new Program();
        I2 i2 = new Program();

        i1.InterfaceMethod();
        i2.InterfaceMethod();


        // if two interfaces have the same method ;
        // you can make one default - lets say interface 3
        // implement i1 normally , and other (i2) explicitly
        // so calling it will give 
        P.InterfaceMethod();

    } 
}
