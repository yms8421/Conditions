using System;

namespace BilgeAdam.Conditions3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plaka Giriniz......: ");
            var plate = Console.ReadLine();
            switch (plate)
            {
                case "01":
                    Console.WriteLine("Adana");
                    break;
                case "02":
                    Console.WriteLine("Adıyaman");
                    break;
                case "03":
                    Console.WriteLine("Afyon");
                    break;
                case "04":
                    Console.WriteLine("Ağrı");
                    break;
                case "05":
                    Console.WriteLine("Amasya");
                    break;
                case "06":
                    Console.WriteLine("Ankara");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Şehir Bulunamadı");
                    break;
            }
            //if (plate == "01")
            //{
            //    Console.WriteLine("Adana");
            //}
            //else if (plate == "02")
            //{
            //    Console.WriteLine("Adıyaman");
            //}
            //else if (plate == "03")
            //{
            //    Console.WriteLine("Afyon");
            //}
            //else if (plate == "04")
            //{
            //    Console.WriteLine("Ağrı");
            //}
            //else if (plate == "05")
            //{
            //    Console.WriteLine("Amasya");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Şehir Bulunamadı");
            //}

            Console.ReadLine();
        }
    }
}
