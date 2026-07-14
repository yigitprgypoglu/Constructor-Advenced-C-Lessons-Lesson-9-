using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    internal class Kisi
    {
        public string _ad;
        public string _soyad;
        public Kisi(string ad,string soyad) //constructor olusturduk.
        {
            _ad=ad;
            _soyad=soyad;
        }

        public Kisi() { }//birden fazla constructor olusturabiliriz.
        //normalde bu verisiz constructoru zaten sistem kendi kendine olusturuyor ama egerki verili bi constructor kullandiysak spnrasinda yeni bir verisiz nesne olusturmak istedigimizde sistem verisiz bir constructor arar ama zaten constructor olusturdugumuz icin ve buda verili oldugu icin bulamaz ve hata verir

        public void BilgiYazdir()
        {
            Console.WriteLine(_ad+" "+_soyad);
        }

    }
}
