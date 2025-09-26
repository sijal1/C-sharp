using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        try
        { 
        // you can use like this or use try-catch as shown below
            throw new UserAlreadyLoggedInException("User ALready Logged in - no duplicate sessions allowed");
        // its not possible for this exception to track the original exceptions ;
        // if i want to provide that capability , then i need to provide that overloaded version of constructor
        
        } 
        catch(UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

//System.Exception class is the base class for all exceptions
public class UserAlreadyLoggedInException : Exception
{
    // providing 2 constructors ; one which does not take parameter and another which takes 
   
    public UserAlreadyLoggedInException() : base()
    {
        
    }
    // the class Exception(go to definiyion) ; it has a constructor which has a string paramerter
    // so you invoke the constructor using base , then pass the message
    public UserAlreadyLoggedInException(string message) : base (message )
    {

    }

    // to throw original exception as said in main
    // so you just call the base message contructor with innerexception
    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
    { }

    //if you want custom exception class to remote-abled or serializable then 
    // decorate this class with serializable attribute 
    // the base constructor has a overloaded constructor for serializable purposes
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    { }
    //now this excpetion is almost equivalent to any other exception class available witihni .NET
}

//