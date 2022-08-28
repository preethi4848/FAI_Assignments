using System;

namespace Week1_Assignments
{
    class Assignment06
    { 
        public static Boolean isValidDate(int day, int month, int year)
        {
            
            if (year < DateTime.MinValue.Year || year > DateTime.MaxValue.Year)
                return false;

            if (month < 1 || month > 12)
                return false;

            return day > 0 && day <= DateTime.DaysInMonth(year, month);
        }

        private static Boolean calledfunction()
        {
            Console.WriteLine("\nPlease write the date in the format Day-Month-Year: ");
            Console.Write("--------------------------------------------------\n");
            String input = Console.ReadLine();
            string[] dateInput = input.Split('-');

            Console.WriteLine("Is the date valid: " + isValidDate(int.Parse(dateInput[0]), int.Parse(dateInput[1]), int.Parse(dateInput[2])));
            if (!isValidDate(int.Parse(dateInput[0]), int.Parse(dateInput[1]), int.Parse(dateInput[2])))
                return false;
            else
            {
                return true;
            }
        }
        public static void Main(string[] args)
        {

            bool looping = true;
            do
            {
                calledfunction();
            } while (looping);

        }
    }
}




