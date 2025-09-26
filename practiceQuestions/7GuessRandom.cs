using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Schema;


namespace AssignmentSolutions
{
    internal class GuessRandom
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(0, 101);
            int userInput;
            int count = 0;

            do
            {
                Console.WriteLine("guess the number : ");
                userInput = Convert.ToInt32(Console.ReadLine());
                count++;


            }
            while (userInput != num);

            if (userInput == num)
            {
                Console.WriteLine("You Took {0} attempts for the random number {1}", count, num);

            }


        }
    }
}
