using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    internal class Program
    {
        
        static int Main(string[] args)
        {
            Kisi birinciK = new Kisi("Yigit","Pirgayipoglu");

            Kisi ikinciK = new Kisi();
            ikinciK._ad = "x";//normalde bu sekilde yazarak kisi class imizda olusturdugumuz degiskenleri adlandirabiliriz
            //ama egerki yukarida nesnemizi olusturdugumuz yerde tanimlamayi yapmak istersek o zaman kisi class imizda constructor olusturmamiz gerekir 
            //constructor kismi kisi classimizda isaretlenmistir.
            
            ikinciK._soyad = "y";
            
            birinciK.BilgiYazdir();
            
            Console.ReadLine();
            return 0;
        }
    }
}
