using System;

namespace Week1_Assignments
{
    class Assignment04
    {
        public static void ArrayIntegers()
        {
            Console.WriteLine("Function that displays the sum of odd numbers and even numbers:");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Enter the size of the array:");

            int size = int.Parse(Console.ReadLine());
            int oddSum = 0, evenSum = 0;
            int[] arg = new int[size];

            Console.WriteLine("Enter the array values:");

            for (int i = 0; i < size; i++)
            {
                arg[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                if (arg[i] % 2 == 0)
                {
                    evenSum += arg[i];
                }
                else
                {
                    oddSum += arg[i];
                }
            }
            Console.WriteLine("Even Sum: " + evenSum + "\nOdd Sum: " + oddSum);

        }
        static void Main(string[] args)
        {
            ArrayIntegers();
        }

    }
}