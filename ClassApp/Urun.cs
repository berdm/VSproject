using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp
{
    public class Urun
    {
        public string urunAdi;
        private double fiyat;


        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }


        public virtual double KDVUygula()
        {
            return fiyat * 1.08;
        }





    }
}
