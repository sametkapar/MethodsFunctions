using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Methods_
{
    internal class Calculator
    {
        public double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }
        public double UsAl(double taban, double us)
        {
            double sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *=taban;
            }
            return sonuc;
        }
    }
}
