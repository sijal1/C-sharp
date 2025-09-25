using System;

namespace AssignmentSolutions
{
    internal class ArmstrongCheck
    {
        static void Main(string[] args)
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
    }
}
