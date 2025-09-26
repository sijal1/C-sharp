using System;
using System.IO;


class Program
{
     public static void Main()
    {
        try
        {
            try
            {
                Console.WriteLine("Enter First Number : ");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number : ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;

                Console.WriteLine("Result = {0}", Result);
                // has many reasons to fail ; alphabets , denomintor - 0 ,very  large number(overflow)
            }
            catch (Exception ex)
            {  //41log.txt
                string FilePath = @"C:\C#\41logAB.txt"; // now what if this file doesnt exixt(before implementing if else to catch it)
                if (File.Exists(FilePath))
                {
                    StreamWriter sw = new StreamWriter(FilePath);
                    sw.Write(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "));
                    sw.WriteLine(ex.GetType().Name);
                    sw.Close();
                    Console.WriteLine("There is an problem , please try later ");
                }
                else
                {
                    // here we are passing (original exception) ex
                    // if we dont ; the innerexception will be null 
                    throw new FileNotFoundException(FilePath + "is not present", ex); 

                    //the outer most try is to catch this 
                }
            }
            finally
            {
            }
        }
        catch (Exception ex1) 
        {
            Console.WriteLine("current exception : {0}", ex1.GetType().Name);
            //if we want the inner exception 
            Console.WriteLine("inner exception : {0}", ex1.InnerException.GetType().Name); // would be null if it(ex in throw ) wasnt passed ;
        }
    }
}

