using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Function_Methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //İhtiyaç duyulduğunda çalıştırmak üzere tanımlanan küçük program parçasına Function(Method) denir.
            //Methodlar sadece ait olduğu nesnesi ile çağırıldığında çalışırlar.

            #endregion

            #region Çırak sınıfı ile metotları öğreniyorum

            //Cirak c= new Cirak();
            //c.isim = "Süleyman";

            //c.SelamSoyle();
            //c.SelamSoyle();
            //c.IsmeSelamSoyle("Muhittin");
            //c.IsmeCokSelamSoyle("Cemil", 6);
            ////c.Uruntanımlama("Domates", "kg", 15);
            //double paraustu = c.CaySoyle(20);
            //Console.WriteLine("Para üstü= " + paraustu);
            //string isim = c.AdinNe();
            //Console.WriteLine(isim);
            //Console.WriteLine(c.AdinNe());

            //Console.WriteLine(c.selamver());

            //Cirak c2 = new Cirak();

            //c2.isim = "Ahmet";
            //Console.WriteLine(c2.AdinNe());


            #endregion

            #region Matematik sınıfı ile metotları kullanıyorum

            //Calculator calc= new Calculator();
            //Console.WriteLine("Bir Sayı Giriniz ");
            //double sayi = Convert.ToDouble(Console.ReadLine());
            ////double gelen = calc.KareAl(sayi);
            //Console.WriteLine("Sayıyın Karesi = " + calc.KareAl(sayi));

            #endregion

            #region UsAl
            //Calculator calc1 = new Calculator();
            //Console.WriteLine("Bir sayı giriniz: ");
            //double taban = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Üs giriniz: ");
            //double us = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Sayının üssü alınmış değer = " + calc1.UsAl(taban, us));
            #endregion

            #region Metin Islem Sınıfı

            MetinIslem mi = new MetinIslem();
            Console.WriteLine("Lütfen Metin Giribiz");
            string isim = Console.ReadLine();
            Console.WriteLine(mi.BastanBoslukSil(isim));
            #endregion

        }
    }
}
