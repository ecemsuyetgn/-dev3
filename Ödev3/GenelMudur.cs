using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenelMudur : Calisan
{
    public GenelMudur(string ad, string soyad, double maas, string departman)
        : base(ad, soyad, "Genel Müdür", maas, departman) { }

    public override void MaasHesapla()
    {
        // Özel maaş hesaplaması
    }
}
