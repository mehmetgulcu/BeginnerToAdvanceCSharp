using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCsharp._4_Conditional_Statements
{
    public class _4_Conditional_Statements
    {
        public void Run()
        {
            int number = 10;
            // If-Else Statement
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
            // Switch Statement
            string day = "Monday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Start of the work week.");
                    break;
                case "Friday":
                    Console.WriteLine("End of the work week.");
                    break;
                default:
                    Console.WriteLine("Midweek days.");
                    break;
            }
            // Ternary Operator
            string result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"The number is {result}.");
        }
    }
}
