using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Schema;


namespace AssignmentSolutions
{
    public static class questions
    {

        public static void Question1_TriangleType()
        //Write a program to accept 3 sides of a triangle and check if the triangle is Equilateral, Isosceles, or Scalene
        {
            //int x, y, z;
            Console.WriteLine("Enter triangle sizes  ");
            Console.Write(" X : ");
            bool b1 = int.TryParse(Console.ReadLine(), out int x);
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


        public static void Question2_ArmstrongCheck()
        // Create a program that determines whether a number is an Armstrong number (e.g., 153 → 1³+5³+3³=153). 
        {
            Console.Write(" enter your number  : ");
            int num = int.Parse(Console.ReadLine());

            int len = num.ToString().Length;

            int sum = 0;

            string num_str = num.ToString();

            foreach (char i in num_str)
            {

                // Convert.ToInt32(i);  // this converts to ascii value
                int digit = int.Parse(i.ToString()); // Convert char to actual digit

                // math.pow -> returns double ; so explicit casting 
                sum += Convert.ToInt32(Math.Pow(digit, len));
            }

            if (sum == num)
            {
                Console.WriteLine(" {0} is an armstrong numebr ", num);
            }
            else
            {
                Console.WriteLine("not an armstrong number");
            }
        }

        public static void Question3_2ndLargestNum()
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


        //Write a program that categorizes an input character as an Uppercase letter, Lowercase letter, Digit,
        //or Special Character, and continues until the user chooses to exit.

        public static void Question4_whichCharacter()
        {
            string userChoice;
            do
            {
                Console.WriteLine("enter your input : ");
                //true means do not display the key when pressed; if i remove that ; i will show double of what i press ; 88;nn,EE
                char ch = Console.ReadKey(true).KeyChar;

                int asciiValue = (int)ch;


                if (asciiValue >= 48 && asciiValue <= 57)
                {
                    Console.WriteLine("{0} is a digit", ch);
                }
                else if (asciiValue >= 65 && asciiValue <= 90)
                {
                    Console.WriteLine("{0} is  UPPERCASE", ch);
                }
                else if (asciiValue >= 97 && asciiValue <= 122)
                {
                    Console.WriteLine("{0} is  lowercase", ch);
                }
                else if (asciiValue == 32)
                {
                    Console.WriteLine(" your character is  space");
                }
                else
                {
                    Console.WriteLine("{0} is a special charcter", ch);
                }


                Console.WriteLine("Do you wish to try again? , type YES");
                Console.WriteLine("type : Yes or NO");
                userChoice = Console.ReadLine().ToUpper();




            }
            while (userChoice != "NO");




        }

        //Implement a program that finds whether a number can be expressed as the sum of two prime numbers. (e.g. 34 = 3+ 31) 
        public static void Question5_NumAsSumofTwoPrimeNum()
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
        public static void Question6_LoginSystem()
        //6.Write a program that simulates a basic login system with maximum 3 attempts using conditional statements.
        {
            string userName = "admin";
            string password = "admin#1221";
            int loginAttempts = 0;
            bool loggedin = false;
            do
            {
                Console.WriteLine("Enter Username : ");
                string inputUsername = Console.ReadLine();
                Console.WriteLine("Enter Password : ");
                string inputPassword = Console.ReadLine();

                loginAttempts++;
                if (inputUsername == userName && inputPassword == password)
                {
                    Console.WriteLine("Logged in ");
                    loggedin = true;
                    break;
                }
                Console.WriteLine("Wrong Credentials , please try again ");
            }
            while (!loggedin && loginAttempts < 3);
            if (!loggedin)
            {
                Console.WriteLine("Exceeded attemts , try again later ");
            }
        }

        public static void Question7_GuessRandom()
        // 7.Write a program that continues until the user correctly guesses a number and display the total number of attempts taken(between 1 - 100).
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

        // 8.Write a program to print all prime numbers between 1 and 500.
        public static void Question8_PrimeNumber500()
        {


            for (int i = 2; i < 500; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
        // Implement a program to check if a given number is a perfect number(sum of divisors = number, e.g., 28).
        public static void Question9_PerfectNumber() 
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

        //  Write a program to print all numbers that are both palindromes and prime numbers within a range. (take range as input from the user)
        public static void Question10_PrimeNPalindrome()
        {
            
        }


        }
}
