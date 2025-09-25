using System;

namespace AssignmentSolutions
{
    internal class TriangleType
    {
        static void Main(string[] args)
        //Write a program to accept 3 sides of a triangle and check if the triangle is Equilateral, Isosceles, or Scalene
        {
            //int x, y, z;
            Console.WriteLine("Enter triangle sizes  ");
            Console.Write(" X : ");
            bool b1 = int.TryParse(Console.ReadLine(),out int x);
            Console.Write(" Y : ");
            bool b2 = int.TryParse(Console.ReadLine(), out int y); 
            Console.Write(" Z : ");
            bool b3 = int.TryParse(Console.ReadLine(), out int z);

            if (b1 && b2 && b3)
            {
                if (x == y && x == z)
                {
                    Console.WriteLine("Equilateral Triangle ");
                }
                else if (x == y || y == z || x == z)
                {
                    Console.WriteLine("Isosceles Triangle ");
                }
                else 
                {
                    Console.WriteLine("Scalene Triangle ");
                }
            }
            else 
            {
                Console.WriteLine(" invalid inputs  ");
            }
        }
    }
}
