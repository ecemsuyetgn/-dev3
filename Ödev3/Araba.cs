using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Araba
{
    public string Marka { get; set; }
    public double YakitTuketimi { get; set; } // 100 km başına litre

    public Araba(string marka, double yakitTuketimi)
    {
        Marka = marka;
        YakitTuketimi = yakitTuketimi;
    }

    public double YakitHesapla(double km)
    {
        return (km / 100) * YakitTuketimi;
    }
}
