using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Başlangıç";
            string kurs3 = "java";

            //array -- dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya Başlangıç", "java" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine("-" + kurs);
            }
        }
    }
}
