using System;
using System.Collections.Generic;
using System.Text;

namespace _1_BasicsOfCsharp._5_Loops
{
    public class _5_Loops
    {
        public void Run()
        {
            // For Loop
            Console.WriteLine("For Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }
            // While Loop
            Console.WriteLine("\nWhile Loop:");
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine($"Iteration {j}");
                j++;
            }
            // Do-While Loop
            Console.WriteLine("\nDo-While Loop:");
            int k = 1;
            do
            {
                Console.WriteLine($"Iteration {k}");
                k++;
            } while (k <= 5);
            // Foreach Loop
            Console.WriteLine("\nForeach Loop:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
