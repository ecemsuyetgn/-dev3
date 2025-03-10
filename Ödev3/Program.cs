// See https://aka.ms/new-console-template for more information
using System;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Ödevler Çalıştırılıyor...\n");

        Odev1_YasKontrol();
        Odev2_ArabaYasiKontrol();
        Odev3_Donguler();
        Odev4_CalisanlarinMaasHesaplamasi();
        Odev5_ArabalarinBenzinTuketimi();
    }

    //  1. ÖDEV: 
    static void Odev1_YasKontrol()
    {
        Console.WriteLine(" 1. Ödev");

        Console.Write("Yaşınızı giriniz: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        if (yas < 0 || yas > 99)
            Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz...");
        else if (yas < 18)
            Console.WriteLine("Küçüksünüz");
        else if (yas < 35)
            Console.WriteLine("Gençsiniz");
        else if (yas < 55)
            Console.WriteLine("Yetişkinsiniz");
        else if (yas < 75)
            Console.WriteLine("Yaşlısınız");
        else
            Console.WriteLine("Çok yaşlısınız");

        Console.WriteLine("-----------------------------");
    }

    //  2. ÖDEV
    static void Odev2_ArabaYasiKontrol()
    {
        Console.WriteLine(" 2. Ödev: ");

        Console.Write("Arabanızın yaşını giriniz: ");
        int arabaYasi = Convert.ToInt32(Console.ReadLine());

        if (arabaYasi < 0 || arabaYasi > 30)
            Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");
        else if (arabaYasi < 10)
            Console.WriteLine("Arabanız yenidir");
        else if (arabaYasi < 20)
            Console.WriteLine("Servise götürmeniz gerekebilir");
        else
            Console.WriteLine("Arabanız hurdaya çıkabilir");

        Console.WriteLine("-----------------------------");
    }

    //  3. ÖDEV: Döngüler
    static void Odev3_Donguler()
    {
        Console.WriteLine(" 3. Ödev: While ve Do-While Döngüleri");

        int i = 0;
        while (i < 25)
        {
            Console.WriteLine("While döngüsü: " + i);
            i++;
        }

        Console.WriteLine("-----------------------------");

        int j = 0;
        do
        {
            Console.WriteLine("Do-While döngüsü: " + j);
            j++;
        } while (j < 25);

        Console.WriteLine("-----------------------------");
    }

    //  4. ÖDEV
    static void Odev4_CalisanlarinMaasHesaplamasi()
    {
        Console.WriteLine(" 4. Ödev");

        List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan("Ahmet", "Yılmaz", "Müdür", 7000, "IT"),
            new GenelMudur("Mehmet", "Kara", 15000, "HR"),
            new Calisan("Zeynep", "Gök", "Programcı", 5000, "IT"),
            new Calisan("Ayşe", "Çelik", "Stajyer", 2000, "Finance")
        };

        double toplamMaas = 0;

        foreach (var calisan in calisanlar)
        {
            calisan.MaasHesapla();
            toplamMaas += calisan.Maas;
        }

        Console.WriteLine($"Toplam Maaş: {toplamMaas} TL");
        Console.WriteLine("-----------------------------");
    }

    //  5. ÖDEV
    static void Odev5_ArabalarinBenzinTuketimi()
    {
        Console.WriteLine(" 5. Ödev:");

        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", 6.5),
            new Araba("BMW", 8.2),
            new Araba("Honda", 5.8),
            new Araba("Mercedes", 9.0)
        };

        double toplamTuketim = 0;
        double mesafe = 500; // 500 km için 

        Console.WriteLine("Arabaların 500 km'de yakıt tüketimleri:");

        foreach (var araba in arabalar)
        {
            double tuketim = araba.YakitHesapla(mesafe);
            toplamTuketim += tuketim;
            Console.WriteLine($"{araba.Marka}: {tuketim:F2} litre");
        }

        Console.WriteLine($"\nToplam Yakıt Tüketimi: {toplamTuketim:F2} litre");
    }
}