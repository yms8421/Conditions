using System;

namespace BilgeAdam.Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            var isim = "Can";
            var a = 9.3;
            var b = -2;
            var c = "Ankara";
            var ad = "can";
            var d = true;
            var e = 4;

            if (a > 0 || b > 0 && e > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Karşılaştırma doğru");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Karşılaştırma istenildiği gibi olmadı");
            }
            Console.ReadLine();
        }
    }
}


/*
    >
    <
    >=
    <=
    ==    =====> Eşitse
    !=    =====> Eşit değilse
    !     =====> Değilse (bool)
    &&    =====> ve
    ||    =====> veya
 */
