using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp
{
    public class CepTelefonu:Urun
    {
        public string marka;

        public CepTelefonu()
        { }

        public CepTelefonu(string urunAdi, double fiyat, string marka )
        {
            this.urunAdi = urunAdi;
            Fiyat = fiyat;
            this.marka = marka;

        }

        public override double KDVUygula()
        {
            return Fiyat * 1.18;
        }
    }
}
