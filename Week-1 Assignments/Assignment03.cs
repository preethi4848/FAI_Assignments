using Week1_Assignments.UserInterface;
using System;

namespace Week1_Assignments
{
    class Assignment03
    {
        static void Main()
        {
            Console.WriteLine("-----The Simple Calculator-----");
            Console.WriteLine("-------------------------------");
            menu();
        }
        private static void menu()
        {
            do
            {
                string option = Util.GetString("Enter 1 for calculator and any other number for exit");
                if (option == "1")
                {
                    int value1 = Util.GetNumber("Enter the first number");
                    int value2 = Util.GetNumber("Enter the second number");
                    string op = Util.GetString("Enter the operator +,-,*,/");
                    int result;
                    switch (op)
                    {
                        case "+":
                            result = value1 + value2;
                            Console.WriteLine("sum is " + result);
                            break;
                        case "-":
                            result = value1 - value2;
                            Console.WriteLine("Difference is " + result);
                            break;

                        case "*":
                            result = value1 * value2;
                            Console.WriteLine("Product is " + result);
                            break;

                        case "/":
                            result = value1 / value2;
                            Console.WriteLine("Quotiont is " + result);
                            break;

                        default:
                            Console.WriteLine("Invalid operator");
                            break;
                    }
                }
                else
                    Environment.Exit(0);



            } while (true);
        }




    }
}