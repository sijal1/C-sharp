using System;
using System.IO;


class Program
{
    public static void Main(string[] args)
    {
        StreamReader streamReader = null;
        try
        {
             streamReader = new StreamReader(@"C:\C#\40exce.txt");
            Console.WriteLine(streamReader.ReadToEnd());
           // streamReader.Close();  -- moved to finally
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check if the File exists : {0}  ", ex.FileName); // no file or wrong file name 
            //if the directory/folder name os wrong .IO.DirectoryNotFoundException: 'Could not find a part of the path 'C:\Csh\40exce.txt'.'
        }
        catch (Exception ex) // using the last net to catch any other errors 
        {
            Console.WriteLine(ex.Message); // no file or wrong file name 
            //if the directory/folder name os wrong .IO.DirectoryNotFoundException: 'Could not find a part of the path 'C:\Csh\40exce.txt'.'
        }
        // what happens if ; streamreader object gets created ; and following line wont be executed (file/path error)
        // comes to catch block and program terminates ; you are never closing the streamreader
        // we use finally for it ; 
        // because it is guaranteed to execute where there is an exception or not
        finally 
        {                            // finally is not mandatory ;
                                     // use case if what is it throws an exception inside catch block
            if (streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("finally block");
        }//release resourcces 
    }
}
// also an practical inheritance example 
// all execption inherits the base Exception class(parent class ; and can point to child object classes  )


//note : most specific exceptions on top and general ones are down below 
// otehr wise (general top,specific bottm ) will give error : prevois catch already catches all exceptions of this or supertype
