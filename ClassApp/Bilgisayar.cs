using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp
{
    class Bilgisayar:Urun
    {

        public Bilgisayar( string urunAdi, double fiyat)
        {
            this.urunAdi = urunAdi;
            Fiyat = fiyat;
        }
    }
}
