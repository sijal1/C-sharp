using System;

class Circle
{
    // both these were instance members, before i made it static 
    // they will duplicated each time you call the objects
    //
    //[  float _PI = 3.141f;  ]
    //
    // its better if we use static
    // there will be 1 copy in memory and is shared by all objects 
    //
    // its not just with fields , but methods as well
    //

    static float _PI = 3.141f;
    int _Radius;

    static Circle() 
    {
        Circle._PI = 3.141f;
        Console.WriteLine("static constructor called  ");
    }

    public Circle(int Radius)
    {
        this._Radius = Radius; // radius is initialized here
        Console.WriteLine("instance  constructor called  ");
    }


    // access modifiers are not allowed on  static constructors
    // >>
    //public static Circle() 
    //{ }
   

    //public static void print() // static method ,
    //{ 
    //}

    public float CalulateArea() //method ; float is return type
    {
        return Circle._PI * this._Radius * this._Radius ;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle C1 = new Circle(5);
        float Area1 = C1.CalulateArea(); // store the retured variable
        Console.WriteLine("Area = {0} ",Area1);

        Circle C2 = new Circle(6);
        float Area2 = C2.CalulateArea(); 
        Console.WriteLine("Area = {0} ", Area2);

        //if i have to invoke static emethod
        // you cannot call static member on instance class
        // i.e :
        //           C!.Print(); is not possible
        //
        //so if i want to use static , you use name of the class
        //           Circle.print();

    }
}