using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp
{
    /*
    temel sınıftaki protected olan marka degiskenine get-set yapılmasa dahi 
    erisebiliriz.protected degisken public gibi davranır.
    */

    //java da ki  extends cs de : dır
    // burdaki tasit sınıfı base classtır.tasit temel classtır. 
    //kamyon sınfı alt sınıftır subclass olarak gecer.
    //Tasit sınıfından turetilmis demektir.
    //Kamyon sınıfı tasit sınıfına ait tum ozellikleri kullanabilir.kendşne ait,
    //dagiskenleri de kullanabilir

    public class Kamyon:Tasit
    {
        private string tasimaKapasitesi;

        public string TasimaKapasitesi
        {
            get { return tasimaKapasitesi; }
            set { tasimaKapasitesi = value; }
        }

        public void Yazdir()
        {
            hiz = 140;
            YakitTuru = "Motorin";
            marka = "Scania";
            tasimaKapasitesi = "1500 cm3";

            Console.WriteLine("Hizi:" + hiz);
            Console.WriteLine("Yakit turu:" +YakitTuru);
            Console.WriteLine("Marka:" +marka);
            Console.WriteLine("Tasima Kapasitesi:" +tasimaKapasitesi);
        }
    }
}
