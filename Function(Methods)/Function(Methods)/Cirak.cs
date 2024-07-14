using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Function_Methods_
{
    internal class Cirak
    {
        public string isim;
        public void SelamSoyle()
        {
            Console.WriteLine("Ustam Selam Söyle ");
            
        }

        //Parametre Alan Metot
        
        public void IsmeSelamSoyle(string isim) //method içine alınan değerlere parameter denir.
        {
            Console.WriteLine(isim + " abi ustam selam söyledi");
        }

        //Method sınırsız sayıda parametre alabilir!!!256
        //Parametreler farklı türlerde olabilir.

        /// <summary>
        ///  İsme çok selam söylemek için
        /// </summary>
        /// <param name="isim"></param>
        /// <param name="adet"></param>
        public void IsmeCokSelamSoyle(string isim, int adet)
        {
            for (int i = 0; i < adet; i++) 
            {
                Console.WriteLine(isim + " abi ustam selam söyledi");
            }
        }
        //public void Uruntanımlama(string isim, string birim, int fiyat)
        //{
        //    string urunisim = isim;
        //    string urunbirim = birim;
        //    int urunfiyat = fiyat;
        //    Console.WriteLine(urunisim +" "+ urunbirim +" "+ urunfiyat);
        //}
        public double CaySoyle(double para)
        {
            double cayfiyat = 5;
            double kalan = para - cayfiyat;
            return kalan;
        }
        public string AdinNe()
        {
            return "Benim adım " + isim;
        }
        public string selamver()
        {
            return "Selamun Aleyküm";
        }

    }
}
