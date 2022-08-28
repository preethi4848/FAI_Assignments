﻿using System;

namespace Week1_Assignments
{
	class Assignment10
	{
		static string[] one = { "", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen ","nineteen " };
		static string[] ten = { "", "", "twenty ", "thirty ", "forty ", "fifty ", "sixty ", "seventy ", "eighty ","ninety " };

		// n is 1- or 2-digit number
		public static string inWords(int n, string s)
		{
			string str = "";

			// if n is more than 19, divide it
			if (n > 19)
				str += ten[n / 10] + one[n % 10];
			else
				str += one[n];

			// if n is non-zero
			if (n != 0)
				str += s;
			return str;
		}

		// Function to print a given number in words
		static string convertToWords(long n)
		{

			// stores word representation of
			// given number n
			string out1 = "";

			out1 += inWords((int)(n / 10000000),"crore ");
			out1 += inWords((int)((n / 100000) % 100),"lakh ");
			out1 += inWords((int)((n / 1000) % 100),"thousand ");
			out1 += inWords((int)((n / 100) % 10),"hundred ");

			if (n > 100 && n % 100 > 0)
				out1 += "and ";

			out1 += inWords((int)(n % 100), "");
			return out1;
		}
		static void Main(string[] args)
		{
        RETRY:
            try
            {
                Console.WriteLine("Function that takes a number between 1 and 99,99,99,999 and returns a String in words:");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("Enter a number between 1 and 99,99,99,999: ");
                long n = int.Parse(Console.ReadLine());
                Console.WriteLine(convertToWords(n));
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number ranges from 1 to 99,99,99,999");
                goto RETRY;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is not in the range of a Integer");
                goto RETRY;
            }
        }
	}
}

