using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Assignments
{
    class Assignment09
    {
        public static void Main(string[] args)
        {
            reverseByWords("");
            Console.WriteLine();
        }
        public static string reverseByWords(string sentence)
        {
            int temp;
            Console.WriteLine("\nProgram in which the words in the original sentence appear in reverse order:");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Enter a sentence: ");
            sentence = Console.ReadLine();
            string[] a = sentence.Split(' ');
            int k = a.Length - 1;
            temp = k;
            for (int i = k; temp >= 0; k--)
            {
                Console.Write(a[temp] + "" + ' ');
                --temp;
            }
            return null;
        }
    }
}
