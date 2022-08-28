using System;

namespace Week1_Assignments
{
    class Assignment05
    {
        private static void simple_interest()
        {
            Console.WriteLine("Function that returns a interest amount:");
            Console.WriteLine("----------------------------------------");
            int principle = readInputs("Enter the principle amount");
            int rate = readInputs("Enter the rate");
            int time = readInputs("Enter the time");
            double interest = (principle * rate * time) / 100;
            Console.WriteLine($"Simple interest is { interest / 2}");
        }
        private static int readInputs(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            simple_interest();   
        }
    }
}