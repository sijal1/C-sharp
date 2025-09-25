using System;

namespace AssignmentSolutions
{
    internal class CharacterCategory
    {
        

        //Write a program that categorizes an input character as an Uppercase letter, Lowercase letter, Digit,
        //or Special Character, and continues until the user chooses to exit.
        static void Main(string[] args)
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

    }
}
