using System;

namespace Week1_Assignments
{
    class Assignment07
    {
        static Boolean isPrimeNumber(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if ((num % i) == 0) return false;
            }
            return true;
            
        }
        public static void Main(string[] args)
        {
            bool looping = true;
            do
            {
            Console.Write("\n\nFunction : To check a number is prime or not :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (isPrimeNumber(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");

            } while (looping);
        }
    }
}
