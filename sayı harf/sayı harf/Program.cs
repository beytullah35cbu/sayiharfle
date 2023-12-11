using System;
namespace or214
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sayi;
            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] yuzler = { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz", "sekizyüz", "dokuzyüz" };

            Console.WriteLine("Sayıyı giriniz (1-999 arası):");
            sayi = Convert.ToInt32(Console.ReadLine());

            int birlerBasamagi = sayi % 10;
            int onlarBasamagi = (sayi / 10) % 10;
            int yuzlerBasamagi = (sayi / 100);

            Console.Write(yuzler[yuzlerBasamagi] + " " + onlar[onlarBasamagi] + " " + birler[birlerBasamagi]);
            Console.ReadLine();

        }
    }
}