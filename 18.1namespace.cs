// name spaces do not corresspond to file,directorry or assembly names 
// they could be written in separate files and still beling tosame namespcae


using System;
//using ProjectA.TeamA;
//using ProjectA.TeamB;  //will cause ambiguity when calling class A
// so use namesspace alias
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamA;
using ProjectA.TeamC; // refer 18ExternalNamespace.cs
//project A
// - team a 
// - team b
class program
{
    public static void Main()
    {
        // ProjectA.TeamA.ClassA.Print(); // fully writing ot 
        //ClassA.Print();                // using ProjectA.TeamA at top  

        //ProjectA.TeamB.ClassA.Print();
        // ClassA = new ClassA();         // ambiguity because , of same class name
        // so using fully writing names

        PATA.ClassA.Print();
        PATB.ClassA.Print();
        ProjectA.TeamC.ClassC.Print();
    }
}

namespace ProjectA
{
    namespace TeamA 
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method ");
            }
        }
    }
}
namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method ");
            }
        }
    }


}


//you can create a new class/namespace ina  different file and
//use the classes from there

