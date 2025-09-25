using System;
//if you want to method overload
// same name - different no. of parameters
//        public static void Add(int a, int b) 
//        public static void Add(int a , int b,int c) 

// you can also have same number of parameters , if the datatypes are different 
//        public static void Add(int a, int b) 
//        public static void Add(float a, float b) 
//        public static void Add(float a, int b)
//        public static void Add(int a, float b)

// you can also have same numebr and type but should have different KINDS of parameters [out,value,ref ]
//            public static void Add(int a ,int b,     int c) 
//            public static void Add(int a, int b, out int sum)

public class Program
{
    static void Main(string[] args)
    {
        
    }

    public static void Add(int a, int b) // static because we can call w/o using obj
    {
        Console.WriteLine("sum = {0}", a+ b);
    }

    public static void Add(float a, float b) 
    {
        Console.WriteLine("sum = {0}", a + b);
    }

    public static void Add(float a, int b)
    {
        Console.WriteLine("sum = {0}", a + b);
    }

    public static void Add(int a , int b,int c) 
    {
        Console.WriteLine("sum = {0}", a + b + c);
    }
    public static void Add(int a, int b, out int sum)
    {
        Console.WriteLine("sum = {0}", a + b );
        sum = a + b;
    }

    public static void Add(int a, int b, int c, int d)
    {
        Console.WriteLine("sum = {0}", a + b + c + d);
    }

}

