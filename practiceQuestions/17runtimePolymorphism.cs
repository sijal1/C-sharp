using System;
//Write a program that demonstrates runtime polymorphism with a Shape base class and overridden Draw() method in Circle, Rectangle, and Triangle. 

public class shape
{
    public virtual void Draw()
    {
        Console.WriteLine(" Base draw method  ");
    }
}
public class Circle : shape
{
    public override void Draw()
    {
        Console.WriteLine(" Circle ");
    }
}
public class Rectangle : shape
{
    public override void Draw()
    {
        Console.WriteLine(" Rectangle  ");
    }
}
public class Triangle : shape
{
    public override void Draw()
    {
        Console.WriteLine(" Triangle  ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        shape[] Sarray = new shape[3];
        Sarray[0] = new Circle();
        Sarray[1] = new Rectangle();
        Sarray[2] = new Triangle();

        foreach (shape i in Sarray) 
        {
            i.Draw();
        }
    }
}
