using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
	class Program
	{
		static void Main(string[] args)
		{
            //There are many different ways to format strings.
			//string myString = "Go to you c:\\ drive";
			//string myString = "My \"so called\" life";
			//string myString = "What if I need \n a new line?";

			//string myString = string.Format("{0}!", "Bonzai");
			//string myString = string.Format("Make: {0} (Model: {1})", "BMW", "706li"); // We have already used this in the mad libs

			//string myString = string.Format("{0:C}", 123.45);
			//string myString = string.Format("{0:N}", 123456789);
			//string myString = string.Format("{0:P}", .123);
            //Formating strings with numbers for this phone number is cool
			//string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890); // It is nice how you can use the hashes for the numbers, then they plug themselves into place.

			//
            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
                //myString += "--" + i.ToString();
            }
             * */

			/*
            StringBuilder myString = new StringBuilder();  // String Builder class is interesting, never heard of it before this.
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--"); // Adds it to the end of the string
                myString.Append(i);
            }
             * */

			string myString = "That summer we took threes across the board";

			//myString = myString.Substring(5, 14);
			//myString = myString.ToUpper(); // Transform it to uppercase
			//myString = myString.Replace(" ", "--");
			myString = String.Format("Length before: {0} -- After: {1}", myString.Length, myString.Trim().Length); //Is string.Format() required for putting in variables?

			Console.WriteLine(myString);
			Console.ReadLine();
		}
	}
}