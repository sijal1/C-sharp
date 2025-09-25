
// polymorphism enables you to invoke derived class method
// through base class referenve at runtime
// 
//in base class : the methodi sdeclared virtual 
// in derived class: we override them 

using System;


public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    // (2) so the solution is to write "virtual" in base class method 
    // it inidcates to derived class that
    // any drived class can override the method(virtual) if the derived class wishes to do 
    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " (base class)");

    }
}
// here using "new" keyword doesnt work 

public class PartTimeEmployee : Employee
    // (1) no changes we made, the child class did not hide parent class ??
    // bwcause we used a base class ref var - and theres another method in 
    // child class
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " (PARTTIME )");
    }
}
public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " (FULLTIME )");
    }
}
public class TempTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " (TEMPORARY  )");

    }
}

class Program
{
    static void Main(string[] args)
    {   
        // here base class ref variable is pointing to child class object
        Employee[] Earray = new Employee[4];
        Earray[0] = new Employee();
        Earray[1] = new PartTimeEmployee();
        Earray[2] = new FullTimeEmployee();
        Earray[3] = new TempTimeEmployee();

        foreach (Employee e in Earray)
        {
            e.PrintFullName();
        }

    }
}

