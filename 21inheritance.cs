using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName() 
    {
        Console.WriteLine(FirstName + " " + LastName);
    }

}
//            derived class   : base class
public class FullTImeEmployee : Employee
{
    public float YearlySalary;
}
public class PartTImeEmployee : Employee
{
    public float HourlyRate;
}


class Program
    {
    static void Main(string[] args)
    {
        FullTImeEmployee FTE = new FullTImeEmployee();
        FTE.FirstName = "Muhammad ";
        FTE.LastName = "Sijal";
        FTE.YearlySalary = 500000 ;
        FTE.PrintFullName();

        PartTImeEmployee PTE = new PartTImeEmployee();
        PTE.FirstName = "part ";
        PTE.LastName = "time";
        PTE.HourlyRate =  300 ;
        PTE.PrintFullName();

    }
}


// to check ;
// the parent class contructor is called when a child class is called 
public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("parent class contructor");
    }
}
public class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("Child  class contructor");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ChildClass CC = new ChildClass();
    }
}

// to control what contructor you want to call in case 
// there are multple constuctor ( contructor overloading  )

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("parent class contructor");
    }

    public ParentClass(string Message )
    {
        Console.WriteLine(Message);
    }
}
public class ChildClass : ParentClass
{
    public ChildClass() 
    {
        Console.WriteLine("Child  class contructor");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ChildClass CC = new ChildClass();
    }
}