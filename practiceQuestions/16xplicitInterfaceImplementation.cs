

//Write a program to demonstrate multiple interface implementation conflict and how to resolve it with explicit interface implementation. 

using System;




class Program
{
    interface IA 
    {
        void Print();
    }
    interface IB 
    {
        void Print();
    }
    interface IC
    {
        void Print();
    }

    class example : IA, IB , IC
    {
        //public void Print()    // it takes this as implementation for both IA,IB 
        //{
        //    Console.WriteLine("COmmon method ");
        //}

        //so to imlement explicitly
        void IA.Print() 
        {
            Console.WriteLine("interface A method");
        }
        void IB.Print()
        {
            Console.WriteLine("interface B method");
        }
        public void Print()
        {
            Console.WriteLine("interface C method");
        }


    }
    static void Main(string[] args)
    {
        example E = new example();
        // (1) p.Print(); //  doesnt exist (because no default ; umnless youmethion explicit like)
        //so

        ((IA)E).Print(); // only way to invoke a explicit interface member
        ((IB)E).Print();

        // or do this 
        IA ia = new example();
        ia.Print();


        E.Print(); // need one to be default  ; public void Print()
    }
}

