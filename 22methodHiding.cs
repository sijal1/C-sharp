// method hiding in C#

using System;

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName() 
    {
        Console.WriteLine(FirstName + " " + LastName + " (base class)");

    }
}

public class PartTimeEmployee : Employee
{
    // the output will be same if you remove the "new"  keyword , but there
    // wont be any warnings 
    public new void PrintFullName()
    {
        // ↑ here this method will hide the base class PrintFullName method
        // it will invoke this method and not the parent class method 
        Console.WriteLine(FirstName + " " + LastName + " - Contractor - (child class)");

        //if you want to call the base class method , even after hiding
        // (method 1) you have to use "base" keyowrd
        //
         base.PrintFullName();
        //                                (method 2 & 3 ) in Main method ↓

    }
}

public class FullTimeEmployee : Employee
{
    public new void PrintFullName()
    {

        Console.WriteLine(FirstName + " " + LastName + " - Full Time - (child class)");

    }
}

public class internEmployee : Employee
{
}

class Program
{
    static void Main(string[] args)
    {
        
        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "PartTime";
        PTE.LastName = "Enployee";
        PTE.PrintFullName();


        // (method 2 )  convert PTE object to be of type PArent
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FullTime";
        FTE.LastName = "EMployee";
        FTE.PrintFullName();    //instead of this 
        // we can use this ↓
        ((Employee)PTE).PrintFullName();



        //  (method 3) 
        // here instead of using child class reference variable , 
        // we can use parent class refence variable 
        Employee FTE_2 = new FullTimeEmployee();   // you cant do FullTimeEmployee FTE_3 = new Employee(); 
        FTE_2.FirstName = "FullTime";              // you will get error( because an parent object
                                                   // cant fulful all respondibilt of child class )
        FTE_2.LastName = "EMployee(FTE_2)";
        FTE_2.PrintFullName();

        // a child class object can fulfill all respondibilty of parent class
        // so this allows us to
        // assign a object of child type to a refeence variable of type parent

        //here FTE_2 is an obj of type Employee, so 
        // FTE_2.PrintFullName(); will call parent class method 

        // a parent class variable --> child class object ; possible
        // a child class variable  --> parent class object ; not possible 
    }
}
