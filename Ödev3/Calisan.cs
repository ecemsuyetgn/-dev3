using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Pozisyon { get; set; }
    public double Maas { get; set; }
    public string Departman { get; set; }

    public Calisan(string ad, string soyad, string pozisyon, double maas, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Pozisyon = pozisyon;
        Maas = maas;
        Departman = departman;
    }

    public virtual void MaasHesapla()
    {
        // Varsayılan maaş hesaplaması
    }
}

