using System;

namespace AssignmentSolutions
{
    internal class SumOfTwoPrimes
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            bool found = false;
            for (int a = 2; a <= n / 2; a++)
            {
                int b = n - a;
                if (IsPrime(a) && IsPrime(b))
                {
                    Console.WriteLine($"{n} = {a} + {b}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No representation as sum of two primes found.");
            }
        }

        static bool IsPrime(int x)
        {
            if (x < 2) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            int limit = (int)Math.Sqrt(x);
            for (int i = 3; i <= limit; i += 2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
