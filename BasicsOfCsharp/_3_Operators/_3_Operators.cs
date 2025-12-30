using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCsharp._3_Operators
{
    public class _3_Operators
    {
        public void Run()
        {
            int a = 10;
            int b = 20;
            // Arithmetic Operators
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {b} - {a} = {b - a}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {b} / {a} = {b / a}");
            Console.WriteLine($"Modulus: {b} % {a} = {b % a}");
            // Comparison Operators
            Console.WriteLine("\nComparison Operators:");
            Console.WriteLine($"{a} == {b}: {a == b}");
            Console.WriteLine($"{a} != {b}: {a != b}");
            Console.WriteLine($"{a} > {b}: {a > b}");
            Console.WriteLine($"{a} < {b}: {a < b}");
            Console.WriteLine($"{a} >= {b}: {a >= b}");
            Console.WriteLine($"{a} <= {b}: {a <= b}");
            // Logical Operators
            bool x = true;
            bool y = false;
            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine($"x && y: {x && y}");
            Console.WriteLine($"x || y: {x || y}");
            Console.WriteLine($"!x: {!x}");
        }
    }
}
