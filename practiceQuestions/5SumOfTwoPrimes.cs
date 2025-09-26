using System;

namespace AssignmentSolutions
{
    internal class SumOfTwoPrimes
    {
         //Implement a program that finds whether a number can be expressed as the sum of two prime numbers. (e.g. 34 = 3+ 31) 
        static void Main(string[] args)
         {
            Console.WriteLine("Enter your number ");
            int num;
            bool b1 = Int32.TryParse(Console.ReadLine(), out num);

            if (!b1 || num < 2)
            {
                Console.WriteLine("Invalid input. Please enter a number greater than 1");
                return;
            }
            //step 1 : primes upto num
            int primeCount = 0;
            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeCount++;
                }
            }
            // step2 primes in array 
            int[] primes = new int[primeCount]; //list would reduce code
            int index = 0;
            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes[index++] = i;
                }
            }
            //step 3 ; prime pairs
            bool found = false;
            for (int i = 0; i < primes.Length; i++)
            {
                int p = primes[i];         // Take one prime number
                int complement = num - p;  // Find what number would complete the sum to 'num'
                for (int j = 0; j < primes.Length; j++)
                {
                    if (primes[j] == complement && p <= complement) //This inner loop checks if complement is also in the list of prime numbers.
                    {
                        Console.WriteLine($"{num} = {p} + {complement}");
                        found = true;
                        break;
                        //If yes, then both p and complement are prime - valid pair
                        // p <= complement avoids printing the same pair twice(e.g., 3 + 31 and 31 + 3).
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine($"{num} cannot be expressed as the sum of two prime numbers.");
            }
        }
    }
}
