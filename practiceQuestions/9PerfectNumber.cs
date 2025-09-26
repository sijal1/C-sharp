using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Schema;


namespace AssignmentSolutions
{
    internal class PerfectNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check for Perfect Number : ");
            int num;
            bool inputValid = int.TryParse(Console.ReadLine(), out num);
            int sum = 0;
            if (inputValid)
            {
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0) 
                    {
                        sum += i;
                    }
                }

                if (sum == num)
                {
                    Console.WriteLine("{0} is an perfect number ",num);
                }
                else
                {
                    Console.WriteLine("{0} is an NOT a perfect number ",num);
                }
            }
            else 
            {
                Console.WriteLine(" invalid input ; enter valid number  ");
            }
        }
    }
}
