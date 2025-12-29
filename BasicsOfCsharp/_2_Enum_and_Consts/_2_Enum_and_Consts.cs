using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCsharp._2_Enum_and_Consts
{
    public class _2_Enum_and_Consts
    {
        public void Run()
        {
            Days days = new Days();
            const double pi = 3.14;

            Console.WriteLine(Days.Monday);
            Console.WriteLine(pi);
        }

        enum Days
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }
    }
}
