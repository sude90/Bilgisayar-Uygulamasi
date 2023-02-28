using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PC
    {
        int[] oyunSecimi = { 0, 1 };
        string PC_situation;


        public string pcSituation = "Kapalı";


        public void PcOpen()
        {
            if (pcSituation == "Kapalı")
            {
                Console.WriteLine("Bilgisayarınız Açılıyor...");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Bilgisayar Açıldı.");
                Thread.Sleep(500);
                Console.Clear();

                pcSituation = "Açık";
            }


        }

        public void PcClose()
        {
            if (pcSituation == "Açık")
            {
                Console.WriteLine("Bilgisayarınız Kapatılıyor...");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Bilgisayar Kapatıldı.");
                Thread.Sleep(500);
                pcSituation = "Kapalı";
            }
        }

        public void pclock()
        {
            int hak = 0;
            while (true)
            {

                string password = "1234";
                Console.WriteLine("----Şifrenizi giriniz----");
                Console.WriteLine("Şifreniz : '1234'");
                string login = Console.ReadLine();
                if (login == password)
                {
                    Console.WriteLine("Bilgisayar kilidi açıldı");
                    Thread.Sleep(500);
                }
                if (login != password)
                {
                    Console.WriteLine("şifre yanlış");
                    Thread.Sleep(500);
                    hak++;
                    Console.Clear();
                }
                if (hak == 3)
                {
                    Console.WriteLine("Fazla yanlış şifre girdiniz uygulamayı kapatıp çıkınız.");
                    Thread.Sleep(500);
                    break;
                }
            }
        }
        public void rock()
        {
            int skor1 = 0;
            int skor2 = 0;
            int oyunsuresi = 3;


            string[] alternatif = new string[3];
            alternatif[0] = "TAŞ";
            alternatif[1] = "KAĞIT";
            alternatif[2] = "MAKAS";

            for (int i = 0; i <= oyunsuresi; i++)
            {
                Console.WriteLine("1. Oyuncu Seçimini Yapabilir");
                Console.WriteLine(" 'TAŞ' - 'KAĞIT' - 'MAKAS' ");

                string secim1 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("2. Oyuncu Seçimini Yapabilir");
                Console.WriteLine(" 'TAŞ' - 'KAĞIT' - 'MAKAS' ");
                string secim2 = Console.ReadLine();
                Console.Clear();


                if (secim1 == alternatif[0] && secim2 == alternatif[0])//berabere ihtimali
                {
                    Console.WriteLine("oyuncular berabere tekrar seçim yapın");
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);

                }
                if (secim1 == alternatif[1] || secim2 == alternatif[1])//berabere ihtimali
                {
                    Console.WriteLine("oyuncular berabere tekrar seçim yapın");
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);
                    Console.Clear();
                }
                if (secim1 == alternatif[2] || secim2 == alternatif[2])//berabere ihtimali
                {
                    Console.WriteLine("oyuncular berabere tekrar seçim yapın");
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);

                }


                if (secim1 == alternatif[1] && secim2 == alternatif[0])//taş kağıt ihtimalleri
                {
                    Console.WriteLine("1. Oyuncu 1 puan aldı.");
                    skor1++;
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);

                }

                else if (secim1 == alternatif[0] && secim2 == alternatif[1])//taş kağıt ihtimalleri
                {
                    Console.WriteLine("2. Oyuncu 1 puan aldı.");
                    skor2++;
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);

                }

                else if (secim1 == alternatif[2] && secim2 == alternatif[1])//kağıt makas ihtimali
                {
                    Console.WriteLine("1. Oyuncu 1 puan aldı.");
                    skor1++;
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);

                }

                else if (secim1 == alternatif[1] && secim2 == alternatif[2])//kağıt makas ihtimali
                {
                    Console.WriteLine("2. Oyuncu 1 puan aldı.");
                    skor2++;
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);

                }

                else if (secim1 == alternatif[2] && secim2 == alternatif[0])//makas taş ihtimali
                {
                    Console.WriteLine("1. Oyuncu 1 puan aldı.");
                    skor1++;
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);
                }

                else if (secim1 == alternatif[0] && secim2 == alternatif[2])//makas taş ihtimali
                {
                    Console.WriteLine("2. oyuncu 1 puan aldı.");
                    skor2++;
                    Console.Clear();
                    Console.WriteLine("1. Oyuncu puanı " + skor1);
                    Console.WriteLine("2. Oyuncu puanı " + skor2);
                }
            }

            if (skor1 > skor2)
            {
                Console.WriteLine("Kazanan Birinci Oyuncu");
            }

            else
            {
                Console.WriteLine("Kazanan İkinci Oyuncu");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void guess()
        {
            Random r = new Random();
            int[] rasgeleSayi = new int[10];
            for (int i = 0; i < rasgeleSayi.Length; i++)
            {
                rasgeleSayi[i] = r.Next(1, 10);
            }
            int puan = 0;
            int puan2 = 0;


            for (int i = 0; i < rasgeleSayi.Length; i++)
            {
                Console.WriteLine((i + 1) + ".soru\n************************");
                Console.WriteLine("1. Oyuncu Tahmini : ");
                int tahmin1 = Convert.ToInt32(Console.ReadLine());
                if (tahmin1 == rasgeleSayi[i])
                {
                    puan += 10;
                    Console.WriteLine("1. Oyuncu Puanı" + puan);
                    Console.WriteLine("2. Oyuncu Puanı" + puan2);
                }
                else
                {
                    if (tahmin1 > rasgeleSayi[i])
                    {

                        puan += 10 - (tahmin1 - rasgeleSayi[i]);
                        Console.WriteLine("1. Oyuncu Puanı" + puan);
                        Console.WriteLine("2. Oyuncu Puanı" + puan2);
                    }
                    else
                    {
                        puan += 10 - (rasgeleSayi[i] - tahmin1);
                        Console.WriteLine("1. Oyuncu Puanı" + puan);
                        Console.WriteLine("2. Oyuncu Puanı" + puan2);
                    }
                    Console.WriteLine("Lütfen 'ENTER' tuşuna basıp devam edin.");
                    Console.Clear();

                    Console.WriteLine("2. Oyuncu Tahmini : ");
                    int tahmin2 = Convert.ToInt32(Console.ReadLine());
                    if (tahmin2 == rasgeleSayi[i])
                    {
                        puan2 += 10;
                        Console.WriteLine("1. Oyuncu Puanı" + puan);
                        Console.WriteLine("2. Oyuncu Puanı" + puan2);
                    }

                    else
                    {
                        if (tahmin2 > rasgeleSayi[i])
                        {

                            puan2 += 10 - (tahmin2 - rasgeleSayi[i]);
                            Console.WriteLine("1. Oyuncu Puanı" + puan);
                            Console.WriteLine("2. Oyuncu Puanı" + puan2);

                        }

                        else
                        {
                            puan2 += 10 - (rasgeleSayi[i] - tahmin2);
                            Console.WriteLine("1. Oyuncu Puanı" + puan);
                            Console.WriteLine("2. Oyuncu Puanı" + puan2);

                        }

                        Console.Clear();
                        Console.WriteLine("1. Oyuncu Puanı : " + puan);
                        Console.WriteLine("2. Oyuncu Puanı : " + puan2);
                        Console.WriteLine("Lütfen 'ENTER' tuşuna basıp devam edin.");

                    }
                    Console.ReadKey();
                }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            PC pc = new PC();
            donus1:
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine(" ");
            Console.WriteLine("1- Bilgisayarı Aç");
            Console.WriteLine("2- Bilgisayarı Kapat");
            int secim = Convert.ToInt16(Console.ReadLine());

            while (secim > 0)
            {
                if (secim == 1)
                {
                    pc.PcOpen();

                    Console.WriteLine("Hangi Oyunu Oynamak İstediğinizi Seçiniz");
                    Console.WriteLine(" ");
                    Console.WriteLine("1- TAŞ - KAĞIT - MAKAS");
                    Console.WriteLine("2- SAYI TAHMİN ETME");
                    int secim2 = Convert.ToInt16(Console.ReadLine());

                    if ( secim2 == 1)
                    {
                        pc.rock();
                    }

                    if ( secim2 == 2)
                    {
                        pc.guess();
                    }
                }

                if (secim == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Bilgisayarınız zaten kapalı! Lütfen doğru seçim yapınız!");
                    Console.WriteLine(" ");
                    goto donus1;
                }

            }
            Console.ReadKey();
        }
    }
}