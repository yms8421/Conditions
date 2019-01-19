using System;

namespace BilgeAdam.Conditions2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                cinsiyet ?
            */
            //yaş 18'den küçükse -> çocuklar bölümüne
            //yaş 65'ten büyükse -> yaşlılar bölümüne
            //kalanlar           -> yetişkinler bölümüne
            Console.Write("Yaşınızı Giriniz......: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cinsiyetiniz.....(E/K): ");
            var gender = Console.ReadKey();
            DecideGender(gender.Key);

            Console.WriteLine();
            Console.WriteLine();

            if (age < 18)
            {
                Console.WriteLine(Redirect("Çocuklar", gender.Key));
            }
            else if (age >= 65) //n defa yazılabilir
            {
                Console.WriteLine(Redirect("Yaşlılar", gender.Key));
            }
            //if(age >= 18 && age < 65)
            else
            {
                Console.WriteLine(Redirect("Yetişkin", gender.Key));
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Verilen alan adına göre yönlendirme metnini oluşturur
        /// </summary>
        /// <param name="area">yönlendirilecek alan adı</param>
        /// <param name="key">cinsiyet için basılan tuş değeri</param>
        /// <returns>yönlendirme mesajı</returns>
        static string Redirect(string area, ConsoleKey key)
        {
            if (key == ConsoleKey.E)
            {
                return "Beyefendi, " + area + " Alanına Geçiniz";
            }
            else if (key == ConsoleKey.K)
            {
                return "Hanımefendi, " + area + " Alanına Geçiniz";
            }
            return area + " Alanına Geçiniz";
        }
        /// <summary>
        /// Ekrandan istenen cinsiyet bilgisine göre yazı rengini değiştirir
        /// </summary>
        /// <param name="key">basılan tuş değeri</param>
        static void DecideGender(ConsoleKey key)
        {
            if (key == ConsoleKey.E)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (key == ConsoleKey.K)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
        }
    }
}
