using System;

namespace KampInro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //değer tutucu
            //Do not repeat yourself * kendini tekrarlama 

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                //simüle edilmesi.
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
