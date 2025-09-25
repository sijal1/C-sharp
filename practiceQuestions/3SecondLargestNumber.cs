using System;

namespace AssignmentSolutions
{
    internal class SecondLargestNumber
    {
        static void Main(string[] args)
       // Implement a program that finds the second largest number in an array without sorting it.
        {
            Console.WriteLine(" Enter Array Size : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine(" Enter Array Elements :  ");
            for (int i = 0; i < n; i++) 
            {
                array[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine(" Array Elements :  ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            int max = int.MinValue;
            int secondmax = int.MinValue;

            //foreach (int i in array)
            //{
            //    if (i > max)
            //    {
            //        secondmax = max;
            //        max = i;
            //    }
            //    else if (i > secondmax && i != max)
            //    {
            //        secondmax = i;
            //    }
            //}

            for (int i = 0; i < n; i++)
            {

                if (array[i] > max)
                {
                    secondmax = max;
                    max = array[i];

                }
                else if (array[i] > secondmax && array[i] != max)
                {
                    secondmax = array[i];
                }
            }

            Console.WriteLine("second max : {0}", secondmax);
        }
    }
}
