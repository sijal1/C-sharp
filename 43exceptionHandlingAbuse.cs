// basically how bad youre implementing the exception handling ?
//  instread of using FormatException,OverflowException,DivideByZeroException,Exception

//use error cheching method 
// like instread of  Convert.ToInt32 use TryParse methods
// check if denominator is 0 ; 

using System;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("enter numberator ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter denominator ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int Result = numerator / denominator;

            Console.WriteLine("Result = {0}", Result);
        }
        catch (FormatException)
        {
            Console.WriteLine("please enter a number ");
        }
        catch (OverflowException)
        {
            Console.WriteLine("only number between {0} and {1} are allowed ", Int32.MinValue, Int32.MaxValue);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("cannot divide by zero");
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }

}
