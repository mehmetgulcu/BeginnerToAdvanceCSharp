using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1_BasicsOfCsharp._7_Quiz
{
    public class _7_1_Quiz
    {
        /// <summary>
        /// 🟢Quiz 1: Kolay Seviye
        /// Sıcaklık Uyarı Sistemi
        /// Kullanıcıdan hava sıcaklığını alan bir program yazman isteniyor.Kurallar:
        /// 0’dan küçükse: “Dışarı çıkma, çok soğuk!”
        /// 0 – 15 arası: “Hava serin, dikkat et.”
        /// 16 – 30 arası: “Hava güzel, tadını çıkar.”
        /// 30’dan büyükse: “Çok sıcak, bol su iç!”
        /// </summary>

        public void Run()
        {
            Main(new string[] { });
        }
        public static void Main(string[] args)
        {
            Console.Write("Hava sıcaklığını giriniz: ");

            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Dışarı çıkma, çok soğuk!");
            }
            else if (temp >= 1 && temp <= 15)
            {
                Console.WriteLine("Hava serin, dikkat et.");
            }
            else if (temp > 16 && temp <= 30)
            {
                Console.WriteLine("Hava güzel, tadını çıkar.");
            }
            else
            {
                Console.WriteLine("Çok sıcak, bol su iç!");
            }
        }
    }
}
