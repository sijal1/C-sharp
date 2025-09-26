using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Schema;


namespace AssignmentSolutions
{
    internal class LoginSystem
    {
        static void Main(string[] args)
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
    }
}
