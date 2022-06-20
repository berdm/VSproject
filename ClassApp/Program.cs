using System;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
        {



            CepTelefonu ceptel = new CepTelefonu("Note 11",7500,"Samsung");
            Console.WriteLine("Odenecek miktar:" + ceptel.KDVUygula()+ "TL");

            Console.WriteLine("");

            Bilgisayar bilgisayar = new Bilgisayar("Lenovo Y540",12000);
            Console.WriteLine("Odenecek Miktar:" + bilgisayar.KDVUygula() + "TL");


            /*

            Tasit otomobil = new Tasit();
            otomobil.hiz = 260;
            otomobil.renk = "Beyaz";
            otomobil.model = 2010;
            otomobil.YakitTuru = "Diesel"; //2. kullanım
            //otomobil.setYakitTuru("Diesel"); // 1.kullanım
            otomobil.Marka = "Renault";
            otomobil.TasitBilgileri();



            Kamyon kamyon = new Kamyon();
            kamyon.Yazdir();
            */



           

            Console.ReadKey();
        }
    }
}
