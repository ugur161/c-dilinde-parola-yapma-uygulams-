using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __dilinde_parola_yapma_uygulamsı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("parola üretici programına hoş geldiniz");
            Console.WriteLine("parolanızda rakam olsunu mu (e/h)");
            string ramakS = Console.ReadLine();
            Console.WriteLine("parolanızda simge olsunu mu (e/h)");
            string simgeS = Console.ReadLine();
            Console.WriteLine("parolanızda büyük harf olsun mu (e/h)");
            string buyukS = Console.ReadLine();
            Console.WriteLine("parolanızda küçük harf olsun mu (e/h)");
            string kucukS = Console.ReadLine();
            Console.WriteLine("parolanız kaç karekterli olsun");
            int uzunluk = Convert.ToInt32(Console.ReadLine());
            bool rakamB, simgeB, buyukB, kucukB;
            rakamB = tipBelirleme(ramakS);
            simgeB = tipBelirleme(simgeS);
            buyukB = tipBelirleme(buyukS);
            kucukB = tipBelirleme(kucukS);
            string uretilenparola = ParolaUretici(buyukB, kucukB, rakamB, simgeB, uzunluk);
            Console.WriteLine("parolanız:" + uretilenparola);
            Console.ReadLine();
        }

        static string ParolaUretici(bool buyuk, bool kucuk, bool
     rakam, bool simge, int uzunluk)
        {
            string uretilenParola = "";
            char[] rakamlar = {
                '0',
                '1',
                '2',
                '3',
                '4',
                '5',
                '6',
                '7',
                '8',
                '9'
            };
            char[] simgeler = { '"', 'é', '!', '#', '+', '$', '%', '½',
              '&', '/', '(', ')', '=', '?', '*', '-', '<', '>', '~', ';',
            ',' };
            char[] kucukHarfler = { 'q', 'w', 'e', 'r', 't', 'y', 'u',
             'o', 'p', 'ğ', 'ü', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k',
             'l', 'ş', 'i', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'ö',
            'ç' };
            char[] buyukHarfler = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U',
             'O', 'P', 'Ğ', 'Ü', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K',
            'Ç' };
            Random r = new Random();
            for (int i = 0; i < uzunluk; i++)
            {
                if (rakam == true)
                {
                    uretilenParola += rakamlar[r.Next(rakamlar.Length)];
                }
                if (simge == true)
                {
                    uretilenParola += simgeler[r.Next(simgeler.Length)];
                }
                if (kucuk == true)
                {
                    uretilenParola += kucukHarfler[r.Next
                    (kucukHarfler.Length)];
                }
                if (buyuk == true)
                {
                    uretilenParola += buyukHarfler[r.Next
                    (buyukHarfler.Length)];
                }
                if (uretilenParola.Length >= uzunluk)
                {
                    break;
                }
            }
            return uretilenParola;
        }

        static bool tipBelirleme(string metin)
        {
            bool tip = false;
            if (metin == "E" || metin == "e")
            {
                tip = true;
            }
            else
            {
                tip = false;
            }
            return tip;
        }
    }
}
