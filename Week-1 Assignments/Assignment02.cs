using System;

namespace Week1_Assignments
{
    class Assignment02
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr = new int[5]; //declare array of integers

            Console.WriteLine("Enter array elements : "); //reading elements
            for (i = 0; i < arr.Length; i++)
            {
                //Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            i = EvenIntegers(arr);
            i = OddIntegers(arr);
        }

        private static int OddIntegers(int[] arr)
        {
            int i;
            Console.WriteLine("List of odd numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return i;
        }

        private static int EvenIntegers(int[] arr)
        {
            int i;
            Console.WriteLine("List of even numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return i;
        }

    }
}