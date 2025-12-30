using System;
using System.Collections.Generic;
using System.Text;

namespace _1_BasicsOfCsharp._6_IO
{
    public class _6_IO
    {
        public void Run()
        {
            Main(new string[] { });
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Input/Output in C#");
            // Example of reading input from the console
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
