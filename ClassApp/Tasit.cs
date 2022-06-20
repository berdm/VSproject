using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp
{
    public class Tasit
    {
        public int hiz;
        public string renk;
        public int model;
        private string yakitTuru; //belirlersek set get yazmak kullanmak zorundayız erisim icin
        protected string marka;   //belirlersek set get yazmak kullanmak zorundayız erisim icin

        /*
         //1. kullanım
        public String getYakitTuru()
        {
            return yakitTuru;
        }

        public void setYakitTuru(string yakitTuru)
        {
            this.yakitTuru = yakitTuru;
        }
        */

        //2.kullanım
        public string YakitTuru
        {
            get
            {
                return yakitTuru;
            }
            set
            {
                yakitTuru = value;
            }
        }



        public string Marka
        {
            get
            {
                return marka;
            }
            set
            {
                marka = value;
            }
        }


        public Tasit()
        {

        }

        public void TasitBilgileri()
        {
            Console.WriteLine("Tasitin hizi:" + hiz);
            Console.WriteLine("Tasitin rengi:" + renk);
            Console.WriteLine("Tasitin modeli:" + model);
            // Console.WriteLine("Tasitin yakit Turu:" +getYakitTuru());  //1. kullanım
           Console.WriteLine("Tasitin yakit turu: " + yakitTuru); //2. kullanım
            Console.WriteLine("Tasitin markasi:" + Marka);
            Console.WriteLine("");
        }
    }
}
