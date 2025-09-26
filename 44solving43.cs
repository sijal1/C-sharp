
using System;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("enter numberator ");
            // int numerator = Convert.ToInt32(Console.ReadLine());
            int numerator;
            bool IsNumeratorValid = Int32.TryParse(Console.ReadLine(), out numerator);
            if (IsNumeratorValid)
            {
                Console.WriteLine("enter denominator ");
                //int denominator = Convert.ToInt32(Console.ReadLine());
                int denominator;
                bool IsDenominatorValid = Int32.TryParse(Console.ReadLine(), out denominator);
                if (IsDenominatorValid && denominator != 0)
                {
                    int Result = numerator / denominator;
                    Console.WriteLine("Result = {0}", Result);
                }
                else 
                {
                    if (denominator == 0)
                    {
                        Console.WriteLine("Denominator cannot be zero ");
                    }
                    else
                    {
                        Console.WriteLine("DEnominator should be a valid numebr between {0} and {1} are allowed ", Int32.MinValue, Int32.MaxValue);
                    }
                       
                }
            }
            else //numerator else
            {
                Console.WriteLine("Numerator should be a valid number between {0} and {1} are allowed ", Int32.MinValue, Int32.MaxValue);
            }
        }
        // you can remove all these specific exceptions , since it is all handled in code
        //
        //catch (FormatException)
        //{
        //    Console.WriteLine("please enter a number ");
        //}
        //catch (OverflowException)
        //{
        //    Console.WriteLine("only number between {0} and {1} are allowed ", Int32.MinValue, Int32.MaxValue);
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("cannot divide by zero");
        //}
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
