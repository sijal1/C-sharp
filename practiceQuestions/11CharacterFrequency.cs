using System;
using System.Collections.Generic;


namespace AssignmentSolutions
{
	internal class CharacterFrequency
	{
		static void Main(string[] args)
		{
			//Write a program to find the frequency of each character in a string using loops. (take string as input from the user) 
			Console.WriteLine("Enter your string to count character frequency : ");
			string UserString = Console.ReadLine();

			Dictionary<char, int> FrequencyDict = new Dictionary<char, int>();

			foreach (char c in UserString) //UserString.ToLower() to convert all into lowercase 
			{
				//if (char.IsLetterOrDigit(c)) {} - to ignore space,digits 
				if (FrequencyDict.ContainsKey(c))
				{
					FrequencyDict[c]++;
				}
				else
				{
					FrequencyDict.Add(c, 1);
					// FrequencyDict[c] = 1;
				}
			}
			foreach (var CF in FrequencyDict)
			{
				Console.WriteLine($"Character '{CF.Key}' occurs {CF.Value} times");
			}
		}
	}
}


