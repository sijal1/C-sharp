using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
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


        public static void Question2_ArmstrongCheck()
        // Create a program that determines whether a number is an Armstrong number (e.g., 153 → 1³+5³+3³=153). 
        {
            Console.Write(" enter your number  : ");
            int num = int.Parse(Console.ReadLine());
            
            int len = num.ToString().Length;

            int sum = 0;

            string num_str = num.ToString();

            foreach(char i in num_str) 
            {
              
                // Convert.ToInt32(i);  // this converts to ascii value
                int digit = int.Parse(i.ToString()); // Convert char to actual digit

                // math.pow -> returns double ; so explicit casting 
                sum += Convert.ToInt32(Math.Pow(digit, len));
            }

            if ( sum == num)
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
                    Console.WriteLine("{0} is a special charcter" ,ch);
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
        
        }


    }
}
