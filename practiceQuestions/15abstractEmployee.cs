

//Create an abstract class Employee with abstract methods CalculateSalary() and GetDetails(). Implement Manager and Developer classes. 

using System;

public abstract class Employee 
{

    public string Name { get; set; }
    public int Id { get; set; }
    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public abstract void CalculateSalary();
    public abstract void GetDetails();

}

public class Manager :  Employee
{
    public Manager(string name,int id) : base(name, id)
    { 

    }
    public override void CalculateSalary()
    {
        Console.WriteLine($"Manager {Name} (ID: {Id}) has a salary of ₹100,000.");
    }
    public override void GetDetails()
    {
        Console.WriteLine($"Manager Details - Name: {Name}, ID: {Id}");
    }

}
public class Developer :  Employee
{
    public Developer(string name, int id) : base(name, id)
    { 
    }
    public override void CalculateSalary()
    {
        Console.WriteLine($"Developer {Name} (ID: {Id}) has a salary of ₹80,000.");
    }
    public override void GetDetails()
    {
        Console.WriteLine($"Developer Details - Name: {Name}, ID: {Id}");
    }

}



class Program
{
    static void Main(string[] args)
    {
        Employee mgr = new Manager("adam ",001);
        mgr.CalculateSalary();
        mgr.GetDetails();

        Employee emp  = new Developer("sijal ",2001);
        emp.CalculateSalary();
        emp.GetDetails();


    }
}

