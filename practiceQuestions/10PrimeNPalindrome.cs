using System;


namespace AssignmentSolutions
{
	internal class PrimeNPalindrome
	{
		static void Main(string[] args)
		{
			//  Write a program to print all numbers that are both palindromes and prime numbers within a range. (take range as input from the user)
			int rangeStart;
			int rangeEnd;
			Console.WriteLine("Entr Starting rangefor prime numbers : ");
			bool bStart = int.TryParse(Console.ReadLine(), out rangeStart);
			if (bStart && rangeStart >= 2)
			{
				Console.WriteLine("Entr range End for prime numbers : ");
				bool bEnd = int.TryParse(Console.ReadLine(), out rangeEnd);
				System.Collections.Generic.List<int> primeList = new System.Collections.Generic.List<int>();

				if (bEnd && rangeEnd > rangeStart)
				{
					for (int i = rangeStart; i <= rangeEnd; i++)
					{
						if (IsPrime(i))
						{
							primeList.Add(i);
						}
					}
					foreach (int prime in primeList)
					{
						if (isPalindrome(prime))
						{
							Console.WriteLine(prime + " ");
						}
					}

				}
				else
				{
					Console.WriteLine("Enter valid ending  range");
				}
			}
			else
			{
				Console.WriteLine("Enter valid starting range");
			}
			bool isPalindrome(int number)
			{
				string str = number.ToString();
				string strRev = "";
				foreach (char i in str)
				{
					strRev = i + strRev;
				}
				return str == strRev;
			}
			bool IsPrime(int number)
			{
				if (number < 2) return false;
				for (int i = 2; i <= Math.Sqrt(number); i++)
				{
					if (number % i == 0)
						return false;
				}
				return true;
			}


			//or
			//
			//string str = number.ToString();
			//string strRev = new string(str.Reverse().ToArray());
			//return str == strRev;


			//if (str == strRev) 
			//{
			//    return true;
			//}
			//return false;

		}
	}
}


