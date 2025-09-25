using System;

// private by default
// can have access modifiers
public abstract class Customer
{ // does not throw error , is legal
    public void Print()
    {
        Console.WriteLine(" abstarct ");
    }
}


// public by default and cannot have access modifiers
public interface Icustomer
{
    // error
    //
    //public void Print()
    //{
    //    Console.WriteLine(" interface  ");
    //}
}



public class Program
{
    static void Main(string[] args)
    {
    }
}

