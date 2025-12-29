using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCsharp._1_Data_Types_and_Variables
{
    public class _1_Data_Types_and_Variables
    {
        string readOnlyValue = "Bu bir readonly değişkendir.";
        public void Run()
        {
            Console.WriteLine("Data Types and Variables sınıfı çalıştırıldı!");

            string exampleString = "Merhaba, C#!";
            int exampleInt = 42;
            double exampleDouble = 3.14;
            bool exampleBool = true;
            char exampleChar = 'C';

            decimal exampleDecimal = 19.99m;
            string exampleDecimalToStr =  Convert.ToString(exampleDecimal);

            Console.WriteLine($"String: {exampleString}");
            Console.WriteLine($"Integer: {exampleInt}");
            Console.WriteLine($"Double: {exampleDouble}");
            Console.WriteLine($"Boolean: {exampleBool}");
            Console.WriteLine($"Character: {exampleChar}");
            Console.WriteLine(readOnlyValue);
            Console.WriteLine(exampleDecimalToStr + " to str");
        }
    }
}
