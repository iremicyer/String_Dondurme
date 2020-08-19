using System;

namespace String_Döndürme_Çalişmasi
{
    class Program
    {

        public static string KelimeBirlestir(string[] kelimeler)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(kelimeler[i]);

            }
            return kelimeler.ToString();
        }
        public static string SayiAl(string[] sayilar)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(sayilar[i]);

            }
            return sayilar.ToString();

        }

        static void Main(string[] args)
        {
            string[] kelimeler = new string[5];
            string kelime = "";
            for (int i = 0; i < 5; i++)
            {
                Console.Write("bir kelime giriniz: \t"); // kullanıcıdan 5 tane kelime alınması
                kelimeler[i] = Console.ReadLine(); // alınan kelimelerin diziye atılması

                kelime += kelimeler[i];
            
            }
            string result = string.Concat(kelimeler[0], kelimeler[1], kelimeler[2], kelimeler[3], kelimeler[4]);
            Console.WriteLine(result);


            string [] sayilar = new string[5];
            string sayi = "";
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Bir sayi giriniz: \t"); // kullanıcıdan 5 tane sayı alınması
                sayilar[i] = (Console.ReadLine()); // alınan sayıların diziye atılması

                sayi += sayilar[i];      
            }
            string sonuc = string.Concat(sayilar[0], sayilar[1], sayilar[2], sayilar[3], sayilar[4]);   // String Concat yöntemi ile iki yada daha fazla string türündeki değerler birleştirilir.
            Console.WriteLine(sonuc);
            

            Program.SayiAl(sayilar); // sayilar dizisindeki elemanların SayiAL fonksiyonuna gönderilmesi
            Program.KelimeBirlestir(kelimeler); // kelimeler dizisindeki elemanların KelimeBirlestir fonksiyonuna gönderilmesi.   
        }
    }
}

